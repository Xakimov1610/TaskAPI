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
        
    - add DbContext to services  ✅
- create migrations and update DB  ✅

# Level 1

In this task, you will configure the controllers

- Create a controller `TasksController`
    - route `/tasks`
- inject DbContext and Logger
    - _context
    - _logger
- create IStorageService
    - Implement DbStorageService
    - inject IStorageService into `TasksController`
- create `Models` folder
    - `NewTask.cs` model
- create model mappers
    - map NewTask mode → Task entity when creating a new task
- create an action with `POST` request.
    - action name 'CreateTaskAsync()'
    - route `/tasks`
    - accepts a task model in the Request Body as JSON object
    - should map NewTask.cs into Task.cs entity model and save it to DB
    - Validation: NewTask MUST have a title.
    - Produces response Codes: 201(Created) or 400 (BadRequest)

# Level 2

- create these models under `Models` folder
    - `Task.cs` model
    - `TaskQuery.cs` model
- create model mappers
    - map Task entity → Task model when returning to user
- create an action with `GET` request.
    - action name 'GetTasksAsync([FromRoute]TaskQuery query)'
    - route `/tasks`
    - returns all tasks which match the query
    - should map all tasks into Task.cs model before returning
    - produces response Codes:
        - 200 (Ok) and return Tasks in the body as JSON
        - 404(NotFound) when no Task found for given Query
