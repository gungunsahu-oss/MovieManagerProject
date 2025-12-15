The Movie Manager Project is a C# console application built to demonstrate core object-oriented programming principles, the use of generic collections, and delegate-based communication. The application manages movies grouped by language and allows basic operations such as adding, removing, and counting movies.

Delegates are used to simulate event-style notifications, where a confirmation message is displayed whenever a movie is successfully added to the system.

Application Flow
Program (Main)
     |
     v
MovieManager
     |
     v
MovieCollection
     |
     v
Dictionary<Language, Dictionary<MovieId, Movie>>

Project Structure Explanation

Movie
Represents the data model for a movie. It stores information such as movie ID, title, actor, actress, and release year.

MovieCollection
Handles all data storage and business logic. Movies are stored using nested dictionaries, where each language maps to a collection of movies identified by unique IDs. This class is responsible for adding, removing, and counting movies.

MovieManager
Acts as the controller layer. It communicates with MovieCollection and uses a delegate to display acknowledgment messages when movies are added. This demonstrates loose coupling and callback-style behavior using delegates.

Program
Contains the Main method and serves as the entry point of the application. It creates movie objects and interacts with MovieManager to perform operations.

Delegate Usage Diagram
AddMovie() called
      |
      v
MovieManager
      |
      v
MovieHandler Delegate
      |
      v
Acknowledgment Message Displayed

Technologies Used

C#
.NET Console Application
Object-Oriented Programming
Delegates
Generic Collections (Dictionary)

Sample Output
Movie Singham added
Movie Taare Zamin Par added
Total Movies: 2
Movie Singham removed from Hindi
Total Movies: 1
