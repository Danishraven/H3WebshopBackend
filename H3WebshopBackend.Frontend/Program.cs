using H3WebshopBackend.API.Controllers;
using H3WebshopBackend.API.Interfaces;
using H3WebshopBackend.Frontend.Services;
using H3WebshopBackend.Repository;
using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Repositories;
using H3WebshopBackend.Services.Interfaces;
using H3WebshopBackend.Services.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<DatabaseContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("connection")));

builder.Services.AddScoped<FrontEndCustomerService>();
builder.Services.AddScoped<FrontEndItemService>();
builder.Services.AddScoped<FrontEndOrderService>();
builder.Services.AddScoped<FrontEndSupplierService>();

////////////////////////////////////////////////////////////////

builder.Services.AddScoped<ICustomerController,  CustomerController>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();


builder.Services.AddScoped<IItemController, ItemController>();
builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<IItemRepository, ItemRepository>();

builder.Services.AddScoped<IOrderController, OrderController>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepositoryTargeted, OrderRepository>();

builder.Services.AddScoped<ISupplierController, SupplierController>();
builder.Services.AddScoped<ISupplierService, SupplierService>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();

////////////////////////////////////////////////////////////////

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();