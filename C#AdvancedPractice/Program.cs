using C_AdvancedPractice;
using C_AdvancedPractice.async_await;
using C_AdvancedPractice.Events;
using C_AdvancedPractice.Multithreading;
using C_AdvancedPractice.Tasks;
using System.Diagnostics;
using System.Reflection;

//*********************Delegates***************************************
//used separate class and made its object as will be using the same project to practice
//Delegates delegates = new Delegates();
//HelloDelegate d = new HelloDelegate(delegates.Hello);
//d("Hello from delegate");
//d("Helluuu");

//List<Employee> empList =
//[
//    new Employee() { ID = 1, Name = "John", Experience = 3, Salary = 70000 },
//    new Employee() { ID = 2, Name = "Bob", Experience = 5, Salary = 100000 },
//    new Employee() { ID = 3, Name = "Mike", Experience = 6, Salary = 150000 },
//    new Employee() { ID = 3, Name = "Joey", Experience = 4, Salary = 90000 },
//];
//Employee.PromoteEmployee(empList);

//when using lambda expression no need of this delegate declaration
//withput lambda
//IsPromotable isPromotable = new IsPromotable(Employee.Promote);
//Employee.PromoteEmployee(empList, isPromotable);

//with lambda
//Employee.PromoteEmployee(empList, e => e.Experience > 5);
//Employee.PromoteEmployee(empList, e => e.Salary >= 90000);

//NotifyDelegate notifyEmail = new NotifyDelegate(NotificationServiecDelegates.SendEmail);
//notifyEmail("You have a new Email!");

//NotifyDelegate notifySms = new NotifyDelegate(NotificationServiecDelegates.SendSms);
//notifySms("You have a new SMS!");

//NotifyDelegate pushNotification = new NotifyDelegate(NotificationServiecDelegates.SendPushNotification);
//pushNotification("You have a new notification!");

//multicast delegates
//NotifyDelegateWithoutInput del1, del2, del3, del4;

//del1 = new NotifyDelegateWithoutInput(NotificationServiecDelegates.SendEmail);
//del2 = new NotifyDelegateWithoutInput(NotificationServiecDelegates.SendSms);
//del3 = new NotifyDelegateWithoutInput(NotificationServiecDelegates.SendPushNotification);

//del4 = del1 + del2 + del3 - del2;
//del4();

//can also do the same chaining using += or -=

//NotifyDelegateWithoutInput del = new NotifyDelegateWithoutInput(NotificationServiecDelegates.SendEmail);
//del += NotificationServiecDelegates.SendSms;
//del  += NotificationServiecDelegates.SendPushNotification;
//del -= NotificationServiecDelegates.SendPushNotification;

//del();

//IntegerDelegate intDel = new IntegerDelegate(NotificationServiecDelegates.Method1);

//intDel += NotificationServiecDelegates.Method2;

//int result = intDel();
//Console.WriteLine(result);

//Exception handling
//ExceptionAbuse.DivideAbuse();
//ExceptionAbuse.Divide();

//NotificationPublisher publisher = new NotificationPublisher();
//Subscriber subscriber = new Subscriber();
//Subscriber2 subscriber2 = new Subscriber2();


//publisher.Notify += subscriber.OnNotificationReceived;
//publisher.Notify += subscriber2.OnNotificationReceived;

//publisher.PublishNotification("Message!!!");

//*****************MULTITHREADING************************
//single threaded synchronous program

//SynchronousProgram.PrintPluses(50);
//SynchronousProgram.PrintMinuses(50);
//Console.WriteLine("Core count: " + Environment.ProcessorCount);
//Console.WriteLine("Main thread's Id: " + Thread.CurrentThread.ManagedThreadId);


//multi threaded program
//Thread t1 = new Thread(() => SynchronousProgram.PrintPluses(100));
//Thread t2 = new Thread(() => SynchronousProgram.PrintMinuses(100));
//t1.Start();
//t2.Start();
//Console.WriteLine("Program is completed");


//creating threads for each job is timeconsuming
//Stopwatch stopwatch = Stopwatch.StartNew();
//for (int i = 0; i < 100; i++)
//{
//    Thread thread = new Thread(SynchronousProgram.PrintA);
//    thread.Start();
//}
//stopwatch.Stop();
//Console.WriteLine(stopwatch.ElapsedMilliseconds);


//thread pooling
//Stopwatch stopwatch2 = Stopwatch.StartNew();
//for (int i = 0; i < 100; i++)
//{
//    ThreadPool.QueueUserWorkItem(SynchronousProgram.PrintA);
//}
//stopwatch2.Stop();
//Console.WriteLine(stopwatch2.ElapsedMilliseconds);

//*****************************TASKS******************************
//creating and starting a task
//Task t1 = new Task(() => SynchronousProgram.PrintPluses(100));
//Task t2 = new Task(() => SynchronousProgram.PrintMinuses(100));
//t1.Start();
//t2.Start();


//instead we can use Task.Run() to directly start a task
//Task t3 = Task.Run(() => SynchronousProgram.PrintPluses(100));
//Task t4 = Task.Run(() => SynchronousProgram.PrintMinuses(100));
//Task t5 = Task.Factory.StartNew(() => SynchronousProgram.PrintMinuses(100));
//Console.ReadLine();

//Returning a value from task
//Task<int> taskWithReturnValue = Task.Run(() => TaskPractice.CalculateStringLength("Hello, there I am learning"));
//Console.WriteLine(taskWithReturnValue.Result); //using result is a blocking operation so the code will stop execution of other operations, thus not recommended to use

//continueWith
//Task taskWithReturnValue = Task.Run(() => TaskPractice.CalculateStringLength("Hello, there I am learning"))
//    .ContinueWith(taskWithReturnValue => Console.WriteLine("Length is " + taskWithReturnValue.Result));


//chaining continuations
//Task taskWithReturnValue = Task.Run(() => TaskPractice.CalculateStringLength("Hello, there I am learning"))
//    .ContinueWith(taskWithReturnValue => Console.WriteLine("Length is " + taskWithReturnValue.Result))
//    .ContinueWith(completedTask =>
//    {
//        Thread.Sleep(500);
//        Console.WriteLine("The second continuation");
//    }
//    );


//array of tasks
//var tasks = new[]
//{
//    Task.Run(()=> TaskPractice.CalculateStringLength("hola amigos")),
//    Task.Run(()=> TaskPractice.CalculateStringLength("hello friends")),
//    Task.Run(()=> TaskPractice.CalculateStringLength("bonjour")),

//};

//var continuationTask = Task.Factory.ContinueWhenAll(tasks, completedTasks => Console.WriteLine(string.Join(",", completedTasks.Select(task => task.Result))));



//wait
//var task = Task.Run(() =>
//{
//    Thread.Sleep(1000);
//    Console.WriteLine("Task is finished");
//});
//task.Wait(); //if we don' use task.wait the further program will execute first and then after that 1s task is finished will be printed
//Console.WriteLine("After the Task");

//Console.WriteLine("Program is completed");
//Console.ReadLine();

//waitAll
//var task1 = Task.Run(() =>
//{
//    Thread.Sleep(1000);
//    Console.WriteLine("Task1 is finished");
//});
//var task2 = Task.Run(() =>
//{
//    Thread.Sleep(1000);
//    Console.WriteLine("Task2 is finished");
//});

//Task.WaitAll(task1, task2);  //if we don' use task.wait the further program will execute first and then after that 1s task is finished will be printed
//Console.WriteLine("After the Task");

//Cancellation of Task
//var cancellationTokenSource = new CancellationTokenSource();
//var task = Task.Run(() => NeverEndingMethod(cancellationTokenSource), cancellationTokenSource.Token);


//string userInput;

//do
//{
//    userInput = Console.ReadLine();
//}while (userInput != "cancel");

//cancellationTokenSource.Cancel();

//Thread.Sleep(5000);
//Console.WriteLine("Program is completed");
//Console.ReadLine();

//static void NeverEndingMethod(CancellationTokenSource cancellationTokenSource)
//{

//    while (true)
//    {
//        //instead of this if we can directly use modified syntax as below
//        //if (cancellationTokenSource.IsCancellationRequested)
//        //{
//        //   // return; //not a good practice, if we use this and even if the task is cancelled the status will be RanToCompletion, it should be Cancelled, so use exceptions
//        //   throw new OperationCanceledException(cancellationTokenSource.Token);
//        //}

//        cancellationTokenSource.Token.ThrowIfCancellationRequested();
//        Console.WriteLine("Working...");
//        Thread.Sleep(3000);
//    }
//}


//Exceptions in thread
//try
//{
//    Thread t1 = new Thread(MethodThrowingException);
//    t1.Start();
//}
//catch
//{
//    Console.WriteLine("Exception caught!!");
//}



//Exceptions in Task 
//Task task;
//try
//{
//    task = Task.Run(() => MethodThrowingException());
//    task.Wait(); // handles exception synchrounously
//}
//catch(Exception ex)
//{
//    Console.WriteLine("Exception caught! Argh!!"+ ex.Message);
//}


//Handling exceptions Asynchrounously
//var task = Task.Run(() => MethodThrowingException())
//    .ContinueWith(faultedTask => Console.WriteLine("Exception caught: " + faultedTask.Exception.Message),
//    TaskContinuationOptions.OnlyOnFaulted);

//static void MethodThrowingException()
//{
//    Console.WriteLine("Inside Method Throwing Exception");
//    throw new Exception("Some Error");
//}


//Handling Aggregate Exceptions
//var task = Task.Run(() => Divide(2,0))
//    .ContinueWith(faultedTask =>
//    {
//        faultedTask.Exception.Handle(ex =>
//        {
//            Console.WriteLine("division task completed");
//            if(ex is ArgumentNullException)
//            {
//                Console.WriteLine("Arguments can't be null");
//                return true; 
//            }
//            if (ex is DivideByZeroException)
//            {
//                Console.WriteLine("Cannot divide by zero");
//                return true;
//            }
//            Console.WriteLine("Unexpected exception type");
//            return false;

//        });
//    });


//Multiple continuations for one task
//var task = new Task(() => Divide(2, 2));

//task.ContinueWith(faultedTask => Console.WriteLine("Success"),
//    TaskContinuationOptions.OnlyOnRanToCompletion);

//task.ContinueWith(faultedTask => Console.WriteLine("Exception caught: " + faultedTask.Exception.Message),
//    TaskContinuationOptions.OnlyOnFaulted);

//task.Start();



//static float Divide(int? a,int? b)
//{
//   if(a is null || b is null)
//    {
//        throw new ArgumentNullException("Arguments cannot be null");
//    }
//   if(b == 0)
//    {
//        throw new DivideByZeroException("Cannot divide by zero");
//    }

//   return a.Value/(float)b.Value;
//}


//Locks
//Locks locks = new Locks();

////asynchronous way changes the value everytime without locks
//var tasks = new List<Task>();

//for (int i = 0; i < 100; i++)
//{
//    tasks.Add(Task.Run(() => locks.Increment()));
//}

//for (int i = 0; i < 100; i++)
//{
//    tasks.Add(Task.Run(() => locks.Decrement()));
//}

//Task.WaitAll(tasks.ToArray());

////synchronous way gives zero always
//locks.Increment();
//locks.Decrement();

//Console.WriteLine("The value of counter is " +locks.Value);


//*****************************ASYNC AWAIT*************************************

//synchronous
//var result = AsyncAwait.CalculateLength("Hello world");
//AsyncAwait.Print(result);


//Console.WriteLine("Start");
//Console.WriteLine("Main" + Thread.CurrentThread.ManagedThreadId);

//var result = AsyncAwait.RunHeavyProcess();

//Console.WriteLine("Doing some work");
//Console.WriteLine("Doing some other work parallely");

//we can replace this block of code with simple async await  
//var task = Task.Run(() => AsyncAwait.CalculateLength("Hello"))
//    .ContinueWith(completedTask => AsyncAwait.Print(completedTask.Result))
//    .ContinueWith(previousContinuation => Console.WriteLine("Process is completed"));

//var task = Process(null);
//static async Task Process(string input)
//{
//    try
//    {
//        var result = await AsyncAwait.CalculateLengthAsync(input);
//        await AsyncAwait.PrintAsync(result);
//        Console.WriteLine("Process is completed");
//    }
//    catch (NullReferenceException ex)
//    {
//        Console.WriteLine("Input cannot be null");
//    }
//}

//string userInput;
//do
//{
//    Console.WriteLine("Command: ");
//    userInput = Console.ReadLine();
//} while (userInput != "stop");


//***********************REF*******************************
//RefDemo.Main();
//RefDemo.Main2();

////Thread.Sleep(1000);
//Console.WriteLine("Program is completed");
//Console.ReadLine();
//Console.WriteLine("Main" + Thread.CurrentThread.ManagedThreadId);


//CONCURRENT BAGS
//ConcurrentBags concurrentBags = new ConcurrentBags();
//Task t1 = Task.Run(() => concurrentBags.NonThreadSafe());
//Task t2 = Task.Run(() => concurrentBags.ThreadSafe());


//EXTENSION METHOD
//string input = "hello";
////string result = StringHelper.ChangeFirstLetterCase(input);
//string result = input.ChangeFirstLetterCase();
////at compilation it just turns it into the above wrapper class and then executes it
//Console.WriteLine(result);



//REFLECTION
//Type T = Type.GetType("C_AdvancedPractice.Reflection.Customer");

//PropertyInfo[] properties = T.GetProperties();
//foreach (PropertyInfo property in properties)
//{
//    Console.Write(property.PropertyType.Name);
//    Console.WriteLine(property.Name);
//}



Console.ReadLine();


