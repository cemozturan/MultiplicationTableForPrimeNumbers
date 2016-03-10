# MultiplicationTableForPrimeNumbers

# How to run it

This is a console application. Simply checkout the solution and run it using Visual Studio. The console itself will display some useful messages so it should be pretty obvious what you need to do once the application is up and running.

# What I'm pleased with

I am quite happy with the overall structure of the program. If another developer looked at the code, I think all parts of the code would be quite easy to understand and follow, in spite of the fact that I used a very limited amount of comments. I tried to make the code be self-explanatory and I believe I have managed to do so.

I like how I managed to split different concerns into smaller classes and tested thoroughly what could possibly happen. I'm quite pleased with my test cases as well, covering the most expected inputs, edge cases and inputs that are expected to end in a failure. In particular, I enjoyed using a TextReader instead of going for Console.ReadLine() straight away. This allowed me to pass in a StringReader in the unit tests and I could test the actual user input in a smooth way.

I have to admit this is by far my most extreme TDD experience, but I have thoroughly enjoyed the process. I was quite happy with how often (except for a couple of minor cases) my tests started passing as soon as I implemented the corresponding bit of code.

I was also pleased with the size and number of my commits. I tried to make many smaller commits so the evolution of the application can easily be observed.

I didn't want to store the whole table before outputting it because for larger numbers, I'd have to store A LOT of data (e.g., if N is 1000, it means storing 1001*1001 cells). I also didn't want to make a lot of Console.WriteLine() calls, so I created and printed individual rows, which I believe gives us the best of both worlds here.

# What I would do with it if I had more time

There are quite a few things that can be improved.

To begin with, I created an IUserInputGetter interface. The idea behind it is that if for some reason in the future, we want to get the input from a place other than the console (e.g., read from a file, etc.), then we could simply add a new IUserInputGetter implementation and whatever is calling the interface wouldn't have to change at all. If this was to be implemented, then I'd change the current TextReaderInputGetter to take in a TextReader in its constructor rather than passing one into the GetInput method. TextReader should really be part of the TextReaderInputGetter class rather than taking place in the GetInput method signature which will affect all implementations of the IUserInputGetter interface.

Another thing is to pull some more code out of the Main method of Program.cs. Currently, the "while" loop that is executed until there is a valid user input isn't tested. It should be pulled out and get tested, which shouldn't be too difficult.

Also, while preparing the output, I could do something similar to what I do with Console.ReadLine() & TextReader. Currently, the main method used Console.WriteLine() quite a few times. One negative outcome of this is that I am not testing the full table output. There are tests for individual rows but ideally the logic to print the whole table should also be pulled out and be tested.

The current use of Console.WriteLine() also makes it more difficult to adapt the code to new requirements. What if we decide to output the table to a file, or send to a database? There should ideally be an interface that handles the output and have different implementations for console, file, DB, etc. so that the code that sends the output doesn't care where the output is going to.

I am happy with the prime number algorithm I am using, but I'd probably take a look at it to see if there is any opportunity for improvement. One of the unit tests ("AnyValidPrimeShouldBeReturned") is taking much longer (292ms compared to a few ms) than the others, so there might be some optimization opportunities there.

While creating the table, I am doing the multiplication for each cell. However, since A*B is equal to B*A, there should be an opportunity to bring down the number of multiplications we perform by quite a bit. Currently, I'm performing both A*B and B*A.

I also haven't spent a lot of time trying to format the output perfectly. It does have a consistent format within itself, but columns won't look perfectly aligned as the number of digits in each cell increase.
