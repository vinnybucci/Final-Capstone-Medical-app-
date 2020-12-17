<template>

  <div class="schedule-Info"> 
    <h1 class="scheduleTitle"></h1>

    <router-link v-bind:to="{name: 'patient'}" ><button class="patientHomePageOffice"></button></router-link>
    <router-link v-bind:to="{name: 'patientOfficeInfo'}"><button class="patientOfficeInfoOfficeBtn"></button></router-link>
    <router-link v-bind:to="{name: 'writeAReview'}"><button class="writeAReview"></button></router-link>
    

    <div class="appointmentList">My Appointment List:</div>
       <span v-for="appointment in appointments" v-bind:key="appointment.id">
          <appointment-patient-card  v-bind:appointment="appointment"/>
       </span>    
    </div>

</template>

<script>
import patientService from "../services/PatientService.js";
import appointmentPatientCard from "../components/AppointmentPatientCard";
export default
 {
components: {
  appointmentPatientCard
},
  data() {
    return {
     appointments:[],
    }
  },
created(){
  patientService.GetMyAppointments(this.$store.state.user.userId).then((response)=>{
    this.appointments=response.data;
  });
}
}
  

</script>

<style scoped>
.appointmentList{
   border: 2px solid black;
    border-radius: 10px;
    font-family: 'Courier New', Courier, monospace;
    background-image: linear-gradient(to bottom right, rgb(255, 255, 255), rgb(218, 236, 53));
       background-size:150%;
        background-repeat: no-repeat;
        background-image: fixed;
        width: 470px;
        margin: 50px;
        padding:10px;
        padding-top: 20px;
        margin-left:270px;
        margin-top:125px ;
}
.apptViewSchedule{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill1.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:35.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.apptViewSchedule:before {
  content: "View Schedule";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.apptViewSchedule:after {
  content: "スケジュールを見る";
  padding-left:50px;
  padding-top: 4px;
  width: 250px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.apptViewSchedule:hover:before {
  top: -50%;
}
.apptViewSchedule:hover:after {
  top: 50%;
}
.reviewsViewScheduleHere{
   font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill4.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:30.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.reviewsViewScheduleHere:before {
  content: "Reviews";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.reviewsViewScheduleHere:after {
  content: "レビュー";
  padding-left:50px;
  padding-top: 4px;
  width: 250px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.reviewsViewScheduleHere:hover:before {
  top: -50%;
}
.reviewsViewScheduleHere:hover:after {
  top: 50%;
}
.officeViewScheduleOffice{
   font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill7.jpg");
       background-size:105%;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:25.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.officeViewScheduleOffice:before {
  content: "Office Info";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.officeViewScheduleOffice:after {
  content: "オフィス情報";
  padding-left:50px;
  padding-top: 4px;
  width: 250px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.officeViewScheduleOffice:hover:before {
  top: -50%;
}
.officeViewScheduleOffice:hover:after {
  top: 50%;
}
#doctorViewScheduleHere {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill3.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:20.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
#doctorViewScheduleHere:before {
  content: "Doctor Home Page";
 
  padding-left:1px ;
  width: 250px;
    top:50%;
  left:48%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
#doctorViewScheduleHere:after {
  content: "ドクターホームページ";
   padding-top:3px ;
  padding-left:1px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
#doctorViewScheduleHere:hover:before {
  top: -50%;
}
#doctorViewScheduleHere:hover:after {
  top: 50%;
}
.doctorViewScheduleHere{
    font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill3.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:16.5%;
  left:9.5%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}

.scheduleTitle {
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
  left:23.7%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.scheduleTitle:before {
  content: "Schedule";

  padding-left: 75px;
  width: 350px;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.scheduleTitle:after {
  content: "スケジュール";
  padding-top: 10px;
  padding-left: 100px;
  width: 450px;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.scheduleTitle:hover:before {
  top: -50%;
}
.scheduleTitle:hover:after {
  top: 50%;
}

.schedule-Info {
  background-image: url("../img/chansey5.jpg");
  background-size: cover;
  background-attachment: fixed;
  background-repeat: no-repeat;
  height: 5000px;
  padding: 50px;
}

.patientHomePageOffice{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill1.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:20.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;}
      
.patientHomePageOffice:before {
  content: "Patient Home Page";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.patientHomePageOffice:after {
  content: "患者のホームページ";
  padding-left:50px;
  padding-top: 4px;
  width: 250px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.patientHomePageOffice:hover:before {
  top: -50%;
}
.patientHomePageOffice:hover:after {
  top: 50%;
}
.patientOfficeInfoOfficeBtn{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill4.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:25.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.patientOfficeInfoOfficeBtn:before {
  content: "Office Info";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.patientOfficeInfoOfficeBtn:after {
  content: "オフィス情報";
  padding-left:50px;
  padding-top: 4px;
  width: 250px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.patientOfficeInfoOfficeBtn:hover:before {
  top: -50%;
}
.patientOfficeInfoOfficeBtn:hover:after {
  top: 50%;
}

.writeAReview{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill3.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:30.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.writeAReview:before {
  content: "Reviews";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.writeAReview:after {
  content: "レビュー";
  padding-left:50px;
  padding-top: 4px;
  width: 250px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.writeAReview:hover:before {
  top: -50%;
}
.writeAReview:hover:after {
  top: 50%;
}

</style>