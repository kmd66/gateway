pushd %~dp0

Kama.ApiManagement\KamaTools\KamaTools.exe -d "Data Source=5.34.200.121; Initial Catalog=Kama.Aro.Organization; User ID=kama; Password=kama@@1389" "Kama.ApiManagement.Infrastructure.DAL" "..\..\Kama.ApiManagement.DAL\DatabaseModel.cs"

pause

Kama.ApiManagement\KamaTools\KamaTools.exe -d "Data Source=5.34.200.121; Initial Catalog=Kama.Log; User ID=kama; Password=kama@@1389" "Kama.ApiManagement.Infrastructure.DAL" "..\..\Kama.ApiManagement.DAL\DatabaseModelLog.cs"

pause