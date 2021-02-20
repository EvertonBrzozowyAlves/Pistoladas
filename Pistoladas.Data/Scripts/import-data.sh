for i in {1..50};
do
    /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Pass123! -d master -i Scripts/DatabaseStructure/001_CreateDatabase.sql
    /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Pass123! -d master -i Scripts/DatabaseStructure/002_USERS_CreateTable.sql
    /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Pass123! -d master -i Scripts/DatabaseStructure/003_USERS_InsertInto.sql
    if [ $? -eq 0 ]
    then
        echo "scripts completed"
        break
    else
        echo "not ready yet..."
        sleep 1
    fi
done