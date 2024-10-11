# CRUDProducts

CRUDProducts is a .NET Core 8 application that implements full CRUD (Create, Read, Update, Delete) operations for managing products.

## Features

- **Add Product:** Ability to add a new product to the database.
- **Edit Product:** Ability to modify an existing product's information.
- **Delete Product:** Ability to remove a product from the database.
- **View Products:** Displays a list of all products.

## Requirements

- .NET Core SDK 8.0+
- Supported Database (e.g., SQL Server, SQLite, etc.)

## Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/your-repository/CRUDProducts.git
    ```

2. Navigate to the project directory:

    ```bash
    cd CRUDProducts
    ```

3. Install the required dependencies:

    ```bash
    dotnet restore
    ```

4. Configure the database connection string in the `appsettings.json` file.

## Running the Application

1. To run the application in development mode, use the following command:

    ```bash
    dotnet run
    ```


## Database Migrations

If the project uses Entity Framework for database interaction, run the following command to apply the migrations:

```bash
dotnet ef database update
