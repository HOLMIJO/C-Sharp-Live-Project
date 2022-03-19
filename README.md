# C-Sharp-Live-Project
Code Summary on C# Live Project

## Introduction
For the last 2 weeks of my time at The Tech Academy, I worked on a team developing a full scale website utilizing ASP.NET MVC and Entity Framework, written in C#.
This project is the interactive website for managing the content and productions for a theater/acting company. The mainframe for the site was already in place. My tasks were geared towards the creation of the interworkings of the Production Member area of the site. 

Below are the descriptions of the stories that I worked on, along with code snippits.

## Front End Stories
* [Styling The Home Page] (#styling-home-page)

### Styling The Home Page
This page was a blank slate. My task was to add and position a logo under the navigation bar, create 2 columns of uneven size, create sections and fill with client specific production posters and related images. Adding a Donations section while linking to related page. Added another section for Land Acknowledgement including text and images, linking to related site.


![Code1](https://user-images.githubusercontent.com/91238285/159121765-c1973694-d4eb-46a0-9da6-42e0446017a2.jpg)
![Code2](https://user-images.githubusercontent.com/91238285/159121767-6d481ff5-e979-4c1d-85bc-b78dd803b028.jpg)
![Code3](https://user-images.githubusercontent.com/91238285/159121768-b9de3dde-de50-4687-81d3-b99cb44a610b.jpg)
![HomePage1](https://user-images.githubusercontent.com/91238285/159121770-64ee27ba-032d-4596-8990-626bd85339c8.jpg)
![HomePage2](https://user-images.githubusercontent.com/91238285/159121773-2e215c76-ee9c-46fc-a711-23ab263c01b3.jpg)
![HomePage-Full](https://user-images.githubusercontent.com/91238285/159121774-a15536de-6d1c-416b-9e72-aa647704e187.jpg)

## Back End Stories
* [CRUD Pages] (#crud-pages)
* [Photo Storage & Retrieval] (#photo-storage-retrieval)
* [Database] (#database)
* [Production Members] (#production-members)

### CRUD Pages
This story required creating an Entity Model for the Production Member area. I created a model, an enum for positions, and CRUD pages with functionality.
By scaffolding the pages using the Entity Framework, I was able to ultimately create, edit and delete new Production Members.

![controller-enum](https://user-images.githubusercontent.com/91238285/159122182-ff16d5b2-81c3-4475-8912-00ca5fe3cb19.jpg)

This story also used styling to meet the predetermined theme of the site. This included enhancing the buttons with rounded corners, centering in the container.

![bandicam 2022-03-19 08-19-38-723](https://user-images.githubusercontent.com/91238285/159122821-4c3f65c6-e4d2-4948-9180-6e6f667eb5ec.jpg)
![bandicam 2022-03-19 08-21-00-837](https://user-images.githubusercontent.com/91238285/159122822-a9f039f0-01fa-4cde-b973-093885e75a18.jpg)

### Photo Storage & Retrieval
For this story we wanted to have images for the ProductionMember model.  To accomplish this, we wanted to allow users to upload files from their file system.  Then, in the controller, the uploaded image was converted into a byte array (byte[]) and stored in the database.  The byte[] representing the photo was able to be retrieved from the database and converted back into an image where it can be displayed on View.

![bandicam 2022-03-19 07-07-24-649](https://user-images.githubusercontent.com/91238285/159123284-23a4e642-75f0-42ce-bd36-41244eda0098.jpg)
![bandicam 2022-03-19 07-07-39-454](https://user-images.githubusercontent.com/91238285/159123285-fa2c19c5-2548-467c-856d-9356b4ac449f.jpg)

### Database
As previously described, I had created the enum for positions, but had also created a database to hold the value of the fields related to the form.
![bandicam 2022-03-19 07-03-53-390](https://user-images.githubusercontent.com/91238285/159123443-ef89e226-3f11-407e-93cc-08d2e4a6224a.jpg)
![bandicam 2022-03-19 06-32-05-327](https://user-images.githubusercontent.com/91238285/159123461-0058a55a-29c9-4b9b-b006-791a2b6d8a29.jpg)
![bandicam 2022-03-19 06-33-10-761](https://user-images.githubusercontent.com/91238285/159123462-8357791e-9e73-44b2-b4bc-42205fd74a20.jpg)

### Production Members
This is the final product of the Production Members Index page. Each image dims upon hover. Each image upon click will return the Production Member's Details page.
![bandicam 2022-03-19 06-37-08-453](https://user-images.githubusercontent.com/91238285/159123631-5885ce06-ebed-4f4e-af1a-c44b9f274906.jpg)
![bandicam 2022-03-19 06-39-38-113](https://user-images.githubusercontent.com/91238285/159123634-91c7519a-5a72-49b2-9ad9-5865212b1ba9.jpg)
![bandicam 2022-03-19 06-27-19-644](https://user-images.githubusercontent.com/91238285/159123635-02d07a18-382f-46bb-81f7-1ae618e413cf.jpg)
![bandicam 2022-03-19 06-27-42-171](https://user-images.githubusercontent.com/91238285/159123636-075f9f7b-5b39-4797-802b-1c4dd1cd29c4.jpg)


https://user-images.githubusercontent.com/91238285/159123637-303d1e3c-ea1a-4aa5-a93a-d0d396df302f.mp4

*Jump to: [Front End Stories](#front-end-stories), [Back End Stories](#back-end-stories), [Page Top](#live-project)*
