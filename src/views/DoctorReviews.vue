<template>
  <div class="doctorReviewBackground">
    <h1 class="doctorAppointmentTitleHere"></h1>
    <router-link v-bind:to="{ name: 'doctor' }"
      ><button
        class="doctorAppointment"
        id="doctorAppointmentButton"
        v-on:click="doctor"
      ></button
    ></router-link>
    <router-link v-bind:to="{ name: 'officeInfo' }"
      ><button class="appointmentOffice" v-on:click="officeInfo"></button
    ></router-link>
    <router-link v-bind:to="{ name: 'appointmentRequest' }"
      ><button
        class="doctorAppointmentRequestBtnHere"
        v-on:click="appointmentRequest"
      ></button
    ></router-link>
    <router-link v-bind:to="{ name: 'viewSchedule' }"
      ><button
        class="appointmentViewSchedule"
        v-on:click="viewSchedule"
      ></button
    ></router-link>
    <review-card/>
  </div>
</template>

<script>
 import reviewCard from '../components/ReviewCard'
import DoctorService from '../services/DoctorService'
 export default {
 components: {
   reviewCard
 
 },
   data() {
    return {
      reviews: [],
      offices: [],
      officeName: "",
      officeId: ""
    };
   },

  created(){
DoctorService.GetMyOffices(this.$store.state.user.userId).then((response) => {
  this.offices = response.data;
})
  },
  methods: {
    getOfficeIdByName(name){
          let selectedOffices = this.offices.filter(office =>{
              return office.name==name;
          });
          this.officeId = selectedOffices[0].officeId;
      },

      getReviews(){
        DoctorService.GetOfficeReviews(this.officeId).then((response) => {
  this.reviews = response.data;
})
      }
  }
 };
 </script>

<style >
.doctorAppointmentTitleHere {
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
  top: 10.5%;
  left: 23.4%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.doctorAppointmentTitleHere:before {
  content: "Reviews Page";

  padding-left: 25px;
  width: 650px;
  top: 50%;
  left: 75%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.doctorAppointmentTitleHere:after {
  content: "レビューページ";
  padding-top: 10px;
  padding-left: 110px;
  width: 650px;
  top: 50%;
  left: 61.5%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.doctorAppointmentTitleHere:hover:before {
  top: -50%;
}
.doctorAppointmentTitleHere:hover:after {
  top: 50%;
}

.doctorReviewBackground {
  background-image: url("../img/drmario4.jpg");
  background-size: cover;
  background-attachment: fixed;
  background-repeat: no-repeat;
  height: 1100px;
}

#doctorAppointmentButton {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: url("../img/pill3.jpg");
  background-size: cover;
  background-repeat: no-repeat;

  height: 35px;
  width: 220px;
  top: 16.5%;
  left: 9.5%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
#doctorAppointmentButton:before {
  content: "Doctor Home Page";

  padding-left: 1px;
  width: 250px;
  top: 50%;
  left: 48%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
#doctorAppointmentButton:after {
  content: "ドクターホームページ";
  padding-top: 3px;
  padding-left: 1px;
  width: 250px;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
#doctorAppointmentButton:hover:before {
  top: -50%;
}
#doctorAppointmentButton:hover:after {
  top: 50%;
}
.appointmentOffice {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: url("../img/pill1.jpg");
  background-size: cover;
  background-repeat: no-repeat;

  height: 35px;
  width: 220px;
  top: 21.8%;
  left: 9.5%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.appointmentOffice:before {
  content: "Office Info";
  padding-top: 2px;
  padding-left: 4px;
  width: 250px;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.appointmentOffice:after {
  content: "オフィス情報";
  padding-left: 50px;
  padding-top: 4px;
  width: 250px;
  top: 50%;
  left: 40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.appointmentOffice:hover:before {
  top: -50%;
}
.appointmentOffice:hover:after {
  top: 50%;
}

.doctorAppointmentRequestBtnHere {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: url("../img/pill4.jpg");
  background-size: cover;
  background-repeat: no-repeat;

  height: 35px;
  width: 220px;
  top: 30.3%;
  left: 10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.doctorAppointmentRequestBtnHere:before {
  content: "Appointment Request";
  padding-top: 2px;
  padding-left: 4px;
  width: 250px;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.doctorAppointmentRequestBtnHere:after {
  content: "予定のリクエスト";
  padding-left: 50px;
  padding-top: 4px;
  width: 250px;
  top: 50%;
  left: 40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.doctorAppointmentRequestBtnHere:hover:before {
  top: -50%;
}
.doctorAppointmentRequestBtnHere:hover:after {
  top: 50%;
}

.appointmentViewSchedule {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: url("../img/pill1.jpg");
  background-size: cover;
  background-repeat: no-repeat;

  height: 35px;
  width: 220px;
  top: 32.4%;
  left: 9.5%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.appointmentViewSchedule:before {
  content: "View Schedule";
  padding-top: 2px;
  padding-left: 4px;
  width: 250px;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.appointmentViewSchedule:after {
  content: "スケジュールを見る";
  padding-left: 50px;
  padding-top: 4px;
  width: 250px;
  top: 50%;
  left: 40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.appointmentViewSchedule:hover:before {
  top: -50%;
}
.appointmentViewSchedule:hover:after {
  top: 50%;
}

.doctor-appointment-requests {
  background-image: url("../img/drmario3.jpg");
  background-size: cover;
  background-attachment: fixed;
  background-repeat: no-repeat;
  background-color: #63f878;
  padding: 25px;
  height: 1500px;
}
</style>