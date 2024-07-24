@echo off

set connectionString="Data Source=94.139.162.23;Initial Catalog=Kama.Aro.Survey;User ID=kama; Password=kama@@1389"

echo ----------------------------------------- Convert SPs 
REM Kama.DevOps.exe -convertSPs "Updates" "db-devops"
REM Kama.DevOps.exe -convertSPs "Synonyms" "db-devops"
REM Kama.DevOps.exe -convertSPs "functions" "db-devops"
REM Kama.DevOps.exe -convertSPs "views" "db-devops"
REM Kama.DevOps.exe -convertSPs "Procedures" "db-devops"

echo ----------------------------------------- Drop objects from db
REM Kama.DevOps.exe -dropAllScripts %connectionString%

echo ----------------------------------------- Execute All scripts on db
REM Kama.DevOps.exe -executeScripts "db-devops\Updates" %connectionString%
Kama.DevOps.exe -executeScripts "Synonyms" %connectionString%
Kama.DevOps.exe -executeScripts "functions" %connectionString%
Kama.DevOps.exe -executeScripts "views" %connectionString%
Kama.DevOps.exe -executeScripts "Procedures" %connectionString%

pause