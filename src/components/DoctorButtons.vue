<template>
  <div class="doctor">
    <h1 class="doctorHomePageTitle"></h1>
    <router-link v-bind:to="{name: 'appointmentRequest'}"><button  class="doctorAppointmentRequest" ></button></router-link>
    <router-link v-bind:to="{name: 'officeInfo'}"><button class="doctorOfficeBtn" ></button></router-link>
    <router-link v-bind:to="{name: 'doctorReviews'}"><button class="doctorReviews"></button></router-link>
    <router-link v-bind:to="{name: 'viewSchedule'}"><button class="doctorViewSchedule" ></button></router-link>

  <doctor-info/>

  

  </div>
</template>

<script>

import doctorInfo from '../components/DoctorInfo';

export default {
  components:{
        doctorInfo,
  },
  data() {
    return {
      appointment: [],
      office: [],
      review: [],
      docDay_office: [],
    };
  },
  methods:{
      appointments(){
          this.$router.push("pathgoeshere");
      },
      officeInfo(){
          this.$router.push("pathgoeshere");
      },
      reviews(){
          this.$router.push("pathgoeshere");
      },
      schedule(){
          this.$router.push("pathgoeshere");
      }
  }
};

</script>

<style>
.doctorHomePageTitle{
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
.doctorHomePageTitle:before {
  content: "Doctor Home Page";
  padding-left:25px ;
  width: 650px;
    top:50%;
  left:64%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.doctorHomePageTitle:after {
  content: "ドクターホームページ";
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
.doctorHomePageTitle:hover:before {
  top: -50%;
}
.doctorHomePageTitle:hover:after {
  top: 50%;
}

.doctor{
  margin:50px;
}
.doctorAppointmentRequest{
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
  overflow: hidden;
  }
      
.doctorAppointmentRequest:before {
  content: "Appointment Requests";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.doctorAppointmentRequest:after {
  content: "予定のリクエスト";
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
.doctorAppointmentRequest:hover:before {
  top: -50%;
}
.doctorAppointmentRequest:hover:after {
  top: 50%;
}

.doctorOfficeBtn{
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
.doctorOfficeBtn:before {
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
.doctorOfficeBtn:after {
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
.doctorOfficeBtn:hover:before {
  top: -50%;
}
.doctorOfficeBtn:hover:after {
  top: 50%;
}


.doctorReviews{
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
.doctorReviews:before {
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
.doctorReviews:after {
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
.doctorReviews:hover:before {
  top: -50%;
}
.doctorReviews:hover:after {
  top: 50%;
}

.doctorViewSchedule{
 font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill7.jpg");
       background-size:105%;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:35.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.doctorViewSchedule:before {
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
.doctorViewSchedule:after {
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
.doctorViewSchedule:hover:before {
  top: -50%;
}
.doctorViewSchedule:hover:after {
  top: 50%;
}
</style>