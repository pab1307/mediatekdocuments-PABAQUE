@echo off
:: ============================================================
::  Script de sauvegarde automatique de la BDD mediatek86
::  Utilise mysqldump (XAMPP/MariaDB)
:: ============================================================

:: --- Paramètres à adapter si nécessaire ---
set MYSQL_PATH=C:\xampp\mysql\bin
set DB_HOST=127.0.0.1
set DB_USER=root
set DB_PASS=
set DB_NAME=mediatek86

:: Dossier où stocker les sauvegardes (même dossier que ce script)
set BACKUP_DIR=%~dp0archives

:: Nombre de sauvegardes à conserver (les plus anciennes sont supprimées)
set NB_MAX=7

:: ============================================================

:: Créer le dossier d'archives s'il n'existe pas
if not exist "%BACKUP_DIR%" mkdir "%BACKUP_DIR%"

:: Nom du fichier horodaté
set TIMESTAMP=%DATE:~6,4%-%DATE:~3,2%-%DATE:~0,2%_%TIME:~0,2%h%TIME:~3,2%
set TIMESTAMP=%TIMESTAMP: =0%
set FICHIER=%BACKUP_DIR%\mediatek86_%TIMESTAMP%.sql

:: Lancer la sauvegarde
echo Sauvegarde en cours : %FICHIER%
"%MYSQL_PATH%\mysqldump.exe" --host=%DB_HOST% --user=%DB_USER% --password=%DB_PASS% --databases %DB_NAME% --result-file="%FICHIER%"

if %ERRORLEVEL% == 0 (
    echo Sauvegarde reussie.
) else (
    echo ERREUR lors de la sauvegarde. Verifier que XAMPP est demarré.
    exit /b 1
)

:: Supprimer les sauvegardes excédentaires (garder les NB_MAX plus récentes)
echo Nettoyage : conservation des %NB_MAX% dernières sauvegardes...
for /f "skip=%NB_MAX% delims=" %%F in ('dir /b /o-d "%BACKUP_DIR%\mediatek86_*.sql"') do (
    echo Suppression : %%F
    del "%BACKUP_DIR%\%%F"
)

echo Terminé.
