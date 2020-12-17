<template>
  <div class="admin-view-container">
      <h1 class="adminHomeTitle"></h1>
      <div class="office-info-container">
        <new-office-form/>
      </div>
      <div class="register-doctor-container">
        <admin-pending-doctors/>
      </div>
  </div>
</template>

<script>
import newOfficeForm from'../components/NewOfficeForm';
import adminPendingDoctors from '../components/AdminPendingDoctors';

export default {
    components:{
        newOfficeForm,
        adminPendingDoctors
    }
}
</script>

<style >
.adminHomeTitle{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: linear-gradient(
    to bottom right,
    rgb(255, 255, 255),
    rgb(228, 228, 228)
  );
  height: 60px;
  width: 730px;
  top:10.5%;
  left:23.4%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
.adminHomeTitle:before {
  content: "Admin Home Page";
  padding-left:25px ;
  width: 650px;
    top:50%;
  left:64%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.adminHomeTitle:after {
  content: "管理者のホームページ";
   padding-top:10px ;
  padding-left:110px ;
  width: 650px;
    top:50%;
  left:50.3%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.adminHomeTitle:hover:before {
  top: -50%;
}
.adminHomeTitle:hover:after {
  top: 50%;
}

  
  .office-info-container {
   margin:20px;
  }
  .admin-view-container{
        background-image:url("../img/drmario.jpg");
       background-size:72%;
       background-position: bottom;
      background-position: right;
        background-attachment: fixed;
        background-repeat: no-repeat;
        padding:25px ;
        height: 1500px;
}
</style>