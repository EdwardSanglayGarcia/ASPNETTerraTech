# <img src="https://upload.wikimedia.org/wikipedia/en/6/65/Map%C3%BAa_University_logo.png" alt="Lamp" width="60" height="60"> Capstone BGS Model View Controller
<p>Final Repository of TerraTech Microtask Crowdsourcing Application</p>

<b><p>TerraTech: A Crowdsourcing Web Application that Aids Environmental Needs and Concerns</p></b>
<p>A Capstone Presented to the School of Information Technology Mapua University</p>
<p>In Partial Fulfillment of the Requirements for the Degree</p>
<p>Bachelor of Science in Information Technology and Bachelor of Science in Information System</p>



Researchers<br />
John Benjet M. Bendita - Backend Engineer<br />
Edward S. Garcia - Lead Developer<br />

Adviser<br />
Prof. Grace Lorraine D. Intal


Master Architecture of TerraTech<br />
![image](https://user-images.githubusercontent.com/42932255/112228713-af47b180-8c6c-11eb-8cbb-d8b247f4097b.png)

Each time a community user submits a specific report, it would first undergo a process of geocoding where the coordinates of the reported concern would be taken together with the description of the concern which would be labelled as “raw report”, this is then transmitted to the function within the TerraTech system to be reverse geocoded to determine the area, city, area code, locality, and postal code for the administrators to immediately determine the in-depth location of the reported concern which would be stored into the database and will be labelled as “processed report”, once it is processed, the administrators can manage these reports by means of accepting or rejecting the concern reported by the user based on the legitimacy of the report submitted and once it is accepted, the report would be assigned to a volunteer who is required to take a photo of the completed concern in order for it to be marked as completed within the system that would be labelled as “finalized report”.

Subversion Status Remodelling<br />
![image](https://user-images.githubusercontent.com/42932255/112228739-bd95cd80-8c6c-11eb-9885-e8913a785929.png)

Developed Microtask Crowdsourcing Components and Functions per International Standards<br />
![image](https://user-images.githubusercontent.com/42932255/112228800-d7cfab80-8c6c-11eb-8799-8749dbf7b753.png)<br />
<br />3.1 USER MANAGEMENT<br />
Register User – the ability of the system to store user information into the TerraTech database.
Evaluate User – checks if the registered user is qualified participate in the crowdsourcing system in which the only requirement is that the user should be inside the borders of the Philippines in land or water.
<br />3.2 TASK MANAGEMENT<br />
Design Task – the ability of the crowdsourcing system to store the types of tasks and sub-tasks being integrated into the system (land and water concern and their sub-categories).
Assign Task – pertains to how the users would be able to participate on the tasks declared on the Design Task.
<br />3.3 CONTRIBUTION MANAGEMENT<br />
Evaluate Contribution – a function of TerraTech where the administrators can evaluate each report submitted by the community users in which they can either accept or reject a report.
Select Contribution – the function of TerraTech that is used in selecting the processed contributions given by the community users through the use of an algorithm, procedure, and data processing techniques.
<br />3.4 WORKFLOW MANAGEMENT<br />
Define Workflow – pertains to the real-life process outside TerraTech where the people would define who would be assigned as the administrators of the system to manage the data.
Manage Workflow – this is the function outside TerraTech where each person performs their respective task such as people who are assigned as administrators needs to manage the reports, while community users need to submit reports, and lastly, volunteers who needs to reject or complete specific reports assigned to them.
<br />4. TECHNICAL BACKGROUND<br />
The TerraTech application is a web application that would be available in multiple devices, the system is presented using HTML5, CSS3, and Bootstrap, while for the functionalities of the user experience, the usage of Leaflet.js, Chart.js, SweetAltert.js, and JQuery for the maps, charts, alerts, and functions respectively. The programming language used for the development was C#, more specifically, MVC5 was used to integrate the overall functionalities together with SQL Server 2018 as its database. 


<br />Finalization: Controller - Dynamic Processing from Database to JSON conversion result
<br />![image](https://user-images.githubusercontent.com/42932255/112229076-457bd780-8c6d-11eb-972d-f098785c4ba5.png)

<br />Twitter Adjustments - Finalized version
<br />![image](https://user-images.githubusercontent.com/42932255/112229132-5f1d1f00-8c6d-11eb-9a8e-801088ab113e.png)

