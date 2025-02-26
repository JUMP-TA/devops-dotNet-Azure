# devops-dotNet-Azure

This repository contains a sample .NET project to be hosted on Azure.

## Project Structure

- **OnlineShoeStoreAPI**: The main project folder containing the .NET API.
  - **Controllers**: Contains the API controllers.
  - **Models**: Contains the data models.
  - **Services**: Contains the service classes for business logic.
  - **Startup.cs**: Configures the services and the app's request pipeline.
  - **Program.cs**: Contains the main entry point of the application.
  - **OnlineShoeStoreAPI.csproj**: The project file containing dependencies and build configurations.

## Setup Instructions

1. **Clone the repository**:
    ```sh
    git clone https://github.com/yourusername/devops-dotNet-Azure.git
    cd devops-dotNet-Azure/OnlineShoeStoreAPI
    ```

2. **Build the project**:
    ```sh
    dotnet build
    ```

3. **Run the project**:
    ```sh
    dotnet run
    ```

4. **Access the API**:
    Open your browser and navigate to `http://localhost:5000`.

## Usage

### Endpoints

- **GET /api/shoes**: Retrieves a list of all shoes.
- **GET /api/shoes/{id}**: Retrieves details of a specific shoe by ID.

### Example Requests

- **Get all shoes**:
    ```sh
    curl -X GET http://localhost:5000/api/shoes
    ```

- **Get shoe details by ID**:
    ```sh
    curl -X GET http://localhost:5000/api/shoes/1
    ```

## Deployment

To deploy this project to Azure, follow these steps:

1. **Login to Azure**:
    ```sh
    az login
    ```

2. **Create a resource group**:
    ```sh
    az group create --name ShoeStoreResourceGroup --location eastus
    ```

3. **Create an App Service plan**:
    ```sh
    az appservice plan create --name ShoeStorePlan --resource-group ShoeStoreResourceGroup --sku B1 --is-linux
    ```

4. **Create a web app**:
    ```sh
    az webapp create --resource-group ShoeStoreResourceGroup --plan ShoeStorePlan --name ShoeStoreApp --runtime "DOTNET|6.0"
    ```

5. **Deploy the app**:
    ```sh
    az webapp deploy --resource-group ShoeStoreResourceGroup --name ShoeStoreApp --src-path .
    ```

6. **Browse to the web app**:
    ```sh
    az webapp browse --resource-group ShoeStoreResourceGroup --name ShoeStoreApp
    ```

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## License

This project is licensed under the MIT License.
