<template>
    <form class="appointment-form" v-on:submit.prevent="PostNewAptRequest()">

        <h2>Submit Appointment Form</h2>
        <label>予約フォームを送信する</label>
        <br/>
        <label>______________________________________________</label><br>
        <label>______________________________________________</label><br><br>
        <label for="doctor"><b>Doctor </b>| 医師:</label>
        <select name="doctor" v-model="appointment.doctorId">
            <option v-for="doctor in doctors" v-bind:key="doctor.userId" v-bind:value="doctor.userId">
                Dr. {{doctor.firstName}} {{doctor.lastName}}
            </option>
        </select><br/>
        <div class="reasonForVisitMessage">
        <label for="reasonForVisit"><b>Reason for visit</b> | 訪問の理由: </label><br/>
        <textarea cols=40 rows=8 v-model="appointment.message"></textarea><br>
        </div>
        <div class="dateTime">
        <label for="date"><b>Date</b> | 日付: </label>
        <input type = "date" v-model="appointment.date"/>
        </div>
        <label for="time"><b>Time</b> | 時間: </label>
        <input name="time" type="time" v-model="appointment.time">
        <br/><br/>

        <button type="submit" class="appointmentSubmit">Submit Appointment Request</button>
    </form>
</template>

<script>
import patientService from '../services/PatientService'
export default {
    data(){
        return{
            appointment: {
                patientId: '',
                doctorId: '',
                message: '',
                date: '',
                time: '',
                status: "Pending"
            },
            doctors: []
        }
    },

    methods: {
        getUserId(){
            return this.$store.state.user.userId
        },

        PostNewAptRequest() {
            patientService.CreateAppointmentRequest(this.appointment)
            .then((response) => {
                if (response.status === 200 || response.status === 201 ) {
                    alert("Appointment Submitted");
                    this.appointment = {};
                }
            })
            .catch((error) => {
                if (error.response.status == 409) {
                     alert("Doctor is unavilable at this time. Please try another time/date");
                    this.appointment.date = '';
                    this.appointment.time = '';
                }
            });
        }
    },

    created(){
      this.appointment.patientId = this.getUserId();
      patientService.GetAllDoctors()
      .then((response) => {
          this.doctors = response.data;
      });
    }

}
</script>

<style >
.appointmentForm{
    border: 2px solid rgb(5, 7, 88);
    margin-right:1000px ;
    margin-top: 40px;
    margin-left: 10px;
    margin-bottom: 40px;
    padding: 10px;
    padding-right: 20px;
}
.feedback-input {
  color:rgb(0, 0, 0);
  font-family: Helvetica, Arial, sans-serif;
  font-weight:500;
  font-size: 18px;
  border-radius: 5px;
  line-height: 22px;
  background-color: transparent;
  border:2px solid #CC6666;
  transition: all 0.3s;
  padding: 13px;
  margin-bottom: 15px;
  width:100%;
  box-sizing: border-box;
  outline:0;
}

.feedback-input:focus { border:2px solid #CC4949; }

.submitJapanese{
    text-align: center;
    text-decoration: overline;
}
.dateTime{
    margin-top:5px ;
}
.reasonForVisitMessage{
    margin-top:20px ;
    margin-left: 10px;
}
.appointment-form{
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
[class="appointmentSubmit"] {
  font-family: 'Montserrat', Arial, Helvetica, sans-serif;
  width: 100%;
  background:#CC6666;
  border-radius:5px;
  border:0;
  cursor:pointer;
  color:white;
  font-size:24px;
  padding-top:10px;
  padding-bottom:10px;
  transition: all 0.3s;
  margin-top:-4px;
  font-weight:700;
}
[class="appointmentSubmit"]:hover { background:#CC4949; }
</style>