FROM mcr.microsoft.com/mssql/server:2019-latest

USER root

COPY Scripts Scripts

RUN chmod +x Scripts/entrypoint.sh

CMD /bin/bash ./Scripts/entrypoint.sh