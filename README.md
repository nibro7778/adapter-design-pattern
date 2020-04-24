# Adapter Design Pattern

## Concept

As per the gang of four definition adapter design pattern "Match interfaces of different classes"

In software engineering adapter pattern allows the incompatible class to interact with the existing class by converting the interface of one class into an interface expected by the client. Adapter pattern help to reuse the existing functionality as it is a bridge between two incompatible interfaces.

Adapters coverts the interface of one class into an interface a client expects

## Real-life example

Let's take a real-life example, Travelling internationally with electronic devices has become so common and the power plug and socket standard are different in different countries so you need an adapter to convert the shape of your home power plugs to the shape of the outlets in the region of the world you are traveling to.

## Scenario (Code Implementation)

We have a product display service that can be display product from two different sources one using file and another by calling the vendor API

So, for the above scenario, we are going to create an IProductSourceAdapter Interface which has Task<IEnumerable<Product>> GetProducts(); So, the client will use this method to get the list of products.

Also, we are going to implement two different classes. One class for file FileSource which get the product from a file using GetProductFromFile method and another for API VendorApiSourcewhich get products by calling Vendor API under GetProducts method

Now, we are going to implement FileSourceAdapter which create an instance of ​​FileSource and delegate the call to FileSource.GetProductFromFile(_filePath)

In the same way, we are going to implement VendorSourceAdapter which create an instance of VendorApiSourceand delegate the call to VendorApiSource.GetProducts(_clientApiUrl)

Now, here our client ProductDisplayService inject IProductSourceAdapterwe don't care about which particular implementation it is. we will get this information based on the type that gets injected.

## Diagram

