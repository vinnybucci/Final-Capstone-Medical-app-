<template>
  <div>
    <div class="doctorsListStyle">
    <h2 class="doctorsList">Doctors List:</h2>
    
   
      <div v-for="doctor in doctors" v-bind:key="doctor.id">
        <label class="doctorUserName">{{ doctor.username }}</label>
        <label class="doctorStatus">{{returnDoctorStatus(doctor)}}</label>
        <button class="activateBtn" type="submit" v-if="doctor.role =='doctor'" v-on:click="doctor.user_role='doctorVerified';ChangeDoctorStatus(doctor)">Activate</button>
        <button class="deactivateBtn" type="submit" v-if="doctor.role =='doctorVerified'" v-on:click="doctor.user_role='doctor';ChangeDoctorStatus(doctor)">Deactivate</button>
      </div>
    </div>
   
  </div>
</template>

<script>
import adminService from "../services/AdminService";

export default {
 
  data() {
    return {
      doctors: [],
    }
  },
  created() {
      adminService.GetPendingDoctors().then((response) => {
        this.doctors = response.data;
      })
    },
  methods:{
    returnDoctorStatus(doctor){
      if(doctor.role == "doctor"){
        return "Not Activated"
      }
      else if(doctor.role == "doctorVerified")
    {
      return "Activated"
    }
    else{
      return "Check Me"
    }
    
    },
    
    ChangeDoctorStatus(doctor) {
      adminService.ChangeDoctorStatus(doctor).then((response) => {
        if (response.status === 200 || response.status === 201) {
          alert("Doctor Status Confirmed");
          adminService.GetPendingDoctors().then((response) => {
        this.doctors = response.data;
      })
        }
      });
    }, 
    
  },
};
</script>

<style >
.doctorsListStyle{
  border: 2px solid black;
    text-align: left;
    border-radius: 10px;
    font-family: 'Courier New', Courier, monospace;
    background-image: linear-gradient(to bottom right, rgb(255, 255, 255), rgb(218, 236, 53));
       background-size:150%;
        background-repeat: no-repeat;
        background-image: fixed;
        width: 415px;
        margin: 50px;
        padding:10px;
        padding-top: 20px;
        margin-left:220px;
        margin-top:50px ;
}
.activateBtn{
  margin: 2px;
}
.deactivateBtn{
  margin: 2px;
}
.doctorsList{
  margin-left: 10px;
}
.doctorUserName{
  border: 2px solid black;
  background-color:white;
  padding: 2px;
  margin: 2px;
  margin-left: 10px;
}
.doctorStatus{
  border: 2px solid black;
  background-color:white;
  padding: 2px;
  margin: 2px;
}
</style>