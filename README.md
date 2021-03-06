This project is an aid to DMs/GMs/SMs playing in the Stars Without Number game system, by Kevin Crawford. While there may be some bindings that would not work with another system like D&D, I have tried to keep it as general as possible so that it can work with a wider variety of systems.

This project is __not__ designed for any kind of public-facing website. There is no authentication at all.

To use the project, either get a binary version by running ```dotnet publish --self-contained=yes -r __OS STRING__``` or simply install the dotnet core 2.2.203 sdk from Microsoft's website and use ```dotnet run```.

In either case, you will need to download and install the SDK, as it is required to scaffold out the database tables.

For Weapons/Equipment/Classes etc., essentially anything based on the book and classified as an "Archetype", simply copy the dmhelper.initial.db to a dmhelper.db file in the same directory. This db should contain all the data necessary to start the game. If it doesnt, file an issue and I will correct.

```
This project is still very much a work in progress. Data migrations may completely or partially delete data from any instance running locally. If in doubt, use your DBMS's backup feature and restore from there.
```