# Project Overview

This project demonstrates a full-stack integration between a Blazor WebAssembly front-end and a .NET Minimal API back-end. The application retrieves a list of products from the server, displays them in the UI, and incorporates performance optimizations such as front-end call reduction and back-end caching.

GitHub Copilot supported the development process by assisting with integration code, debugging, JSON structuring, and performance tuning.

# How to Run the Project

1. **Start the ServerApp**

dotnet run


2. **Start the ClientApp**

dotnet run


3. **Open the Blazor App**  
Navigate to the URL printed in the console (typically http://localhost:5195).

# Project Structure

| Folder / File        | Description                                      |
|----------------------|--------------------------------------------------|
| ServerApp            | Minimal API project serving product data         |
| ClientApp            | Blazor WebAssembly front-end                     |
| ProductData.cs       | Static cache for product list                    |
| FetchProducts.razor  | UI component fetching and displaying products    |
| Models               | Shared data models for JSON deserialization      |
| README.md            | Project documentation                            |
| REFLECTION.md        | Reflective summary for Step 4                    |

# Reflective Summary

## How Copilot Assisted Throughout the Project

Copilot played a central role in helping me build, debug, and optimize this full-stack application. It assisted in several key areas:

### Generating integration code  
Copilot helped scaffold the Minimal API endpoint, the Blazor `HttpClient` logic, and the model classes needed to deserialize JSON responses. It also guided the structure of the API routing and ensured the front-end and back-end communicated correctly.

### Debugging issues  
When I encountered CORS errors, incorrect routing, or serialization mismatches, Copilot suggested fixes such as adjusting middleware order, correcting endpoint paths, and refining model definitions. These suggestions helped me resolve issues faster and understand the underlying causes.

### Structuring JSON responses  
Copilot helped design a nested JSON structure that included product categories, and it guided me in shaping the corresponding C# models. This ensured smooth deserialization and clean data flow from the server to the UI.

### Optimizing performance  
Copilot recommended reducing redundant API calls in the Blazor front-end and implementing a static caching strategy in the back-end. These optimizations improved load times and reduced unnecessary server work.

## Challenges I Encountered and How Copilot Helped

Throughout the project, I ran into several challenges:

- **CORS configuration issues**  
Copilot helped identify that the CORS middleware needed to be placed before endpoint mapping and suggested the correct configuration.

- **JSON deserialization errors**  
When the front-end failed to parse the API response, Copilot helped me align the C# models with the JSON structure and suggested using wrapper classes like `ProductResponse`.

- **Caching implementation confusion**  
I initially attempted to use `CacheOutput`, which wasn’t available in my project template. Copilot helped me pivot to a static caching strategy using a dedicated `ProductData` class.

- **Network debugging confusion**  
When I struggled to locate the `/api/productlist` request in DevTools, Copilot guided me through filtering, reloading, and manually triggering the request.

Each challenge became a learning opportunity with Copilot acting as a guide rather than a crutch.

## What I Learned About Using Copilot Effectively

This project taught me how to use Copilot as a collaborative tool rather than a code generator:

- Copilot accelerates development, but I still need to understand the code it suggests.  
- Specific prompts lead to better suggestions — vague prompts produce vague results.  
- Copilot is great at spotting patterns, such as repeated code or inefficient logic.  
- It reinforces best practices like proper middleware ordering, clean model design, and performance-aware coding.  
- Copilot works best when paired with my own reasoning, especially when dealing with architecture or framework-specific behavior.

Overall, Copilot helped me work faster, learn more deeply, and build a more polished full-stack application.
