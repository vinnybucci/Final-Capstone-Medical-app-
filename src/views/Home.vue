<template>
<div >
   <h1 class="homeLogo"></h1>
    <h1 class="homeView">About</h1>
    <p class="homeView2">Our mission is to provide excellent medical care in a family centered environment. We firmly embrace the concept of the medical home, a 
      centralized base for caring for children and their entire family. Our philosophy is shared by all our staff, from physicians to the front desk. 
      We value the relationships with our families, and enjoy caring for newborns through young adults. We are committed to continuously educating ourselves 
      and incorporating the best of technology to provide excellent care.</p>
      
    <p class="homeView2">We strive to build long-term, partnering relationships built on trust and mutual respect; We believe in prevention of disease and promotion of healthy 
      life-styles for all children; We strive to be an efficient and cost-effective practice in meeting the needs of children during times of health as
       well as in times of illness; We practice medicine as a team and value the contributions of all of our staff in providing excellent medical care and 
       service; We believe in the ethical practice of medicine, provide leadership throughout the community and provide service of those in our community in need.</p>
      
    
    <dr-mario-img/>
  </div>

  
</template>

<script>
import drMarioImg from '../components/DrMarioImg.vue'
export default {
  components:{
    drMarioImg
  },
  name: "home"
};
</script>
<style scoped>
.homeView
{
  padding-top:30px;
  padding-left:50px;
  padding-right:50px;
  text-align: center;
}
.homeView2
{
 
  padding-left:50px;
  padding-right:50px;
  text-align: center;
}
.homeLogo{
        background-image:url("../img/DrMarioMedApp.jpg");
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        padding:25px ;
        height: 1500px;
}
</style>
