<template>
  <div class="writeReviewImg">

    <h1 class="patientReviewTitle"></h1>
    <router-link v-bind:to="{name: 'patient'}" ><button class="patientHomePageReviews"></button></router-link>
    <router-link v-bind:to="{name: 'patientOfficeInfo'}"><button class="patientOfficeInfoReviewsBtn"></button></router-link>
    <router-link v-bind:to="{name: 'patientViewSchedule'}"><button class="viewPatientSchedule"></button></router-link>

    <patient-review-form/>
  </div>
</template>

<script>
import patientReviewForm from '../components/PatientReviewForm';

export default {
    components:{
        patientReviewForm
    }

}
</script>

<style >
.writeReviewImg{
     background-image:url("../img/chansey3.jpg");
        padding: 50px;
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        background-color: #cdffcc;
        height: 1100px;
        }

.patientReviewTitle {
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
  width: 710px;
  top:10.5%;
  left:22.8%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
.patientReviewTitle:before {
  content: "Write a Review";
  padding-left:25px ;
  width: 650px;
    top:50%;
  left:67%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.patientReviewTitle:after {
  content: "レビューを書く";
   padding-top:10px ;
  padding-left:110px ;
  width: 650px;
    top:50%;
  left:58.8%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.patientReviewTitle:hover:before {
  top: -50%;
}
.patientReviewTitle:hover:after {
  top: 50%;
}

.patientHomePageReviews{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill1.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        background-color: #cdffcc;
        
  height: 35px;
  width: 220px;
  top:20.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;}
      
.patientHomePageReviews:before {
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
.patientHomePageReviews:after {
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
.patientHomePageReviews:hover:before {
  top: -50%;
}
.patientHomePageReviews:hover:after {
  top: 50%;
}

.patientOfficeInfoReviewsBtn{
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
.patientOfficeInfoReviewsBtn:before {
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
.patientOfficeInfoReviewsBtn:after {
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
.patientOfficeInfoReviewsBtn:hover:before {
  top: -50%;
}
.patientOfficeInfoReviewsBtn:hover:after {
  top: 50%;
}

.viewPatientSchedule{
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
.viewPatientSchedule:before {
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
.viewPatientSchedule:after {
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
.viewPatientSchedule:hover:before {
  top: -50%;
}
.viewPatientSchedule:hover:after {
  top: 50%;
}
</style>