// Write your JavaScript here.
//--------------------Fetch------------------------------
import { categoriesFetch, itemsFetch, restaurantFetch } from "./dataservices.js";  


//-------------------------grab elements----------------------------------------//

const restName1 = document.getElementById("restaurant-name");




//-------------------------Functions----------------------------------------//

const restaurantName = async (id) => {
    
    const rest = await restaurantFetch(id);
    restName1.textContent = rest.name;

    console.log(rest);
}

restaurantName(1);

