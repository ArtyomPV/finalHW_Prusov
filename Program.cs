string[] array = {"1234", "1567", "-2", "computer science"};
int maxLength = 3;
int lengthNewArray;
string[] newArray;

bool askUserCreateArray() {
    Console.Write("Вы желаете заполнить массив, да или нет? ");
    string request = Console.ReadLine();
    switch (request.ToLower()){
        case "да": 
        return true;
        
        case "нет": 
        return false;
        
        default:
        Console.WriteLine("Вы неверно ответили!");
        return askUserCreateArray();
    }
}

string[] createUserArray() {
    Console.Write("Введите количесво элеметов массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string [length];
    for(int i = 0; i < length; i++) {
        Console.WriteLine("Введите значение элемента:");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

int findLengthNewArray(string[] arr){
    int length = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= maxLength)
        {
            length++;
        }
    }
    return length;
}

string[] createNewArray(string[] arr, int length){
    string[] newArr = new string[length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= maxLength)
        {
            newArr[count] = arr[i];
            count++;
        }
    }
    return newArr;
}

void showArray(string[] arr){
    Console.Write ("[");
    for(int i = 0; i < arr.Length; i++){
        if(i == arr.Length-1) {
            Console.Write($"\"{arr[i]}\"");
        } else {
            Console.Write($"\"{arr[i]}\", ");
            }
        }
    Console.Write ("]");
}

if(askUserCreateArray()){
   array =  createUserArray();
} 

 lengthNewArray = findLengthNewArray(array);
 newArray = createNewArray(array, lengthNewArray);
showArray(newArray);

// string[] newArray() {

// // }
// Console.WriteLine();
// Console.WriteLine(askUserCreateArray());
// string[] array = {"1234", "1567", "-2", "computer science"};
// int maxLength;
// Console.WriteLine(findLengthNewArray(array));
// showArray(array);