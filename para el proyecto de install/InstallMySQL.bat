echo on
cls
echo Starting Install...
set mysql_msi="C:\Program Files (x86)\ITDECSA\installSicaV4.1\mysql-5.5.14-win32.msi"
set mysql_svname=MySQL
set mysql_datadir="C:\ProgramData\MySQL\MySQL Server 5.5\data"
set mysql_data2="C:\Program Files (x86)\MySQL\MySQL Server 5.5\data"
set mysql_cmd="GRANT ALL PRIVILEGES ON *.* TO 'root'@'%' IDENTIFIED BY 'mysql' WITH GRANT OPTION;"

msiexec /i %mysql_msi% /qn INSTALLDIR="C:\Program Files (x86)\MySQL\MySQL Server 5.5\" /L* C:\MSI-MySQL-Log.txt
echo MySQL Version 5.5.14 installed...
md %mysql_data2%

"C:\Program Files (x86)\MySQL\MySQL Server 5.5\bin\mysqlinstanceconfig.exe" -i -q ServiceName=MySQRayme RootPassword=mysql ServerType=DEVELOPMENT DatabaseType=MYISAM Port=3306 RootCurrentPassword=mysql
echo MySQL Instance Configured...Service started...

rem Uncomment next line to allow root access from any pc...
"C:\Program Files (x86)\MySQL\MySQL Server 5.5\bin\mysql.exe" -uroot -pmysql -e %mysql_cmd%

"C:\Program Files (x86)\MySQL\MySQL Server 5.5\bin\mysql.exe" -uroot -pmysql -e "drop database asistencia"
"C:\Program Files (x86)\MySQL\MySQL Server 5.5\bin\mysql.exe" -uroot -pmysql -e "create database asistencia"

msiexec /qn /i %mysql_odbc% /L* C:\MSI-MySQL-ODBC-Log.txt
echo ODBC Connector installed...

msiexec /qn /i %mysql_gui% /L* C:\MSI-MySQL-GUI-Log.txt
echo MySQL GUI Tools installed...

echo on
