// ***************  TASK 1 *****************

// const array = [-454,-89,6,89,-4,5,-1644];
// let minimumElement = array[0];
// for (let i = 0; i < array.length; i++) {
//     if (array[i]<minimumElement) {
//         minimumElement=array[i]
//     }
// }
// console.log(minimumElement);


// ***************  TASK 2 ******************

const array = [454,9,6,89,5,];
let sum = 0;
for (let i = 0; i < array.length; i++) {
    if(array[i] >=0 && array[i] <=9){
        sum++;
    }   
}
console.log(sum);