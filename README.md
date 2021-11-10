# TaskAPI
## Level 0

After each task, build the solution and write a commit

- create empty WebApi, clean-up template resources ✅
- define entities (`Task`) ✅
- create DbContext and configure SqlServer/Sqlite connection ✅
    - add packages
        
        ```bash
        microsoft.entityframeworkcore --version 5.0
        microsoft.entityframeworkcore.design --version 5.0
        microsoft.entityframeworkcore.sqlserver --version 5.0
        microsoft.entityframeworkcore.sqlite --version 5.0
        ```  ✅
        
    - add DbContext to services
- create migrations and update DB
