for i in {1..50};
do
    /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Pass123! -d master -i Scripts/001_CreateDabase.sql
    /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Pass123! -d master -i Scripts/002_CreateTableUsers.sql
    if [ $? -eq 0 ]
    then
        echo "scripts completed"
        break
    else
        echo "not ready yet..."
        sleep 1
    fi
done