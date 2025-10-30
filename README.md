# 🛍️ MyFirstWebApp

A **.NET MVC e-commerce web application** featuring user authentication, shopping cart functionality, and an admin dashboard to manage products and users.

---

## 🚀 Features

- User registration & login system  
- Add to Cart / Remove from Cart  
- Product listing with images  
- Admin panel for managing users and products  
- SQL Server database integration  
- Responsive Bootstrap UI  

---

## 🧩 Tech Stack

- **Frontend:** HTML, CSS, Bootstrap  
- **Backend:** ASP.NET Core MVC (C#)  
- **Database:** Microsoft SQL Server  
- **IDE:** Visual Studio Code  

---

⚙️ Installation & Setup

Follow these steps to set up and run the project locally:

1️⃣ Clone the Repository
git clone https://github.com/your-username/MyFirstWebApp.git


(Replace your-username with your actual GitHub username.)

2️⃣ Open the Project

Open the folder in Visual Studio Code or Visual Studio.

Make sure you have .NET SDK (8.0 or later) installed.

3️⃣ Install Dependencies

Run this command in the terminal:

dotnet restore


This restores all NuGet packages your project needs.

4️⃣ Set Up the Database

Open the file appsettings.json and update your SQL Server connection string:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=MyFirstWebAppDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}


Replace YOUR_SERVER_NAME with your local SQL Server instance name.

5️⃣ Apply Migrations

Run the following command to create the database:

dotnet ef database update


(If you don’t have EF tools, install them first using dotnet tool install --global dotnet-ef)

6️⃣ Run the Application

Start your server:

dotnet run


Then open your browser and visit:
👉 http://localhost:5000

(or the URL shown in your terminal)

7️⃣ Done!

You can now:

Register a new user

Log in

Add products to cart

Explore the website 🎉
## 🖼️ Screenshots

### 🏠 Home Page
![Home Page](./screenshots/home.png)

### 💻 Products Page
![Products Page](./screenshots/product.png)

### 🛒 Cart Page
![Cart Page](./screenshots/cart.png)

### 🔐 Register Page
![Register Page](./screenshots/register.png)
