<template>
<div>
  <form v-on:submit.prevent="CreateNewOffice()" class="createOfficeForm">
    <h3>Create New Office Form:</h3><br>
    <div class="createNewOfficeFormText">
    <label for="name">Name: </label>
    <input type="text" required v-model="office.name" /><br />

    <label for="streetAddress">Street Address: </label>
    <input
      id="streetAddress"
      required
      v-model="office.streetAddress"
    /><br />

    <label for="streetAddress2">Street Address 2: </label>
    <input id="streetAddress2" v-model="office.streetAddress2" /><br />

    <label for="City">City: </label>
    <input id="City" required v-model="office.City" /><br />

    <label for="state">State: </label>
    <input id="state" required v-model="office.state" /><br />

    <label for="zip">Zip: </label>
    <input id="zip" required v-model="office.zip" /><br />

    <label for="phoneNumber">Phone Number: </label>
    <input id="phoneNumber" required v-model="office.phone" /><br />

    <div for="officeHours">Office Hours:</div>
    <br />
    <!-- <label for="monday">Monday</label>
<input for="monday" type ="time" v-model="this.office.monday.start"/>
<input for="monday" type ="time" v-model="this.office.monday.end"/><br>
<label for="tuesday">Tuesday</label>
<input for="tueday" type ="time" v-model="this.office.tuesday.start"/>
<input for="tueday" type ="time" v-model="this.office.tuesday.end"/><br>
<label for="wednesday">Wednesday</label>
<input for="wednesday" type ="time" v-model="this.office.wednesday.start"/>
<input for="wednesday" type ="time" v-model="this.office.wednesday.end"/><br>
<label for="thursday">Thursday</label>
<input for="thursday" type ="time" v-model="this.office.thursday.start"/>
<input for="thursday" type ="time" v-model="this.office.thursday.end"/><br>
<label for="friday">Friday</label>
<input for="friday" type ="time" v-model="this.office.friday.start"/>
<input for="friday" type ="time" v-model="this.office.friday.end"/><br>
<label for="saturday">Saturday</label>
<input for="saturday" type ="time" v-model="this.office.saturday.start"/>
<input for="saturday" type ="time" v-model="this.office.saturday.end"/><br>
<label for="sunday">Sunday</label>
<input for="sunday" type ="time" v-model="this.office.sunday.start"/>
<input for="sunday" type ="time" v-model="this.office.sunday.end"/><br> -->

    <button type="submit">Create Office</button>
    </div>
  </form>
</div>
</template>

<script>
import adminService from "../services/AdminService";

export default {
  data() {
    return {
      office: {
        name: "",
        streetAddress: "",
        streetAddress2: "",
        city: "",
        state: "",
        zip: "",
        phone: "",
        // monday: {
        //   start: "",
        //   end: "",
        // },

        // tuesday: {
        //   start: "",
        //   end: "",
        // },

        // wednesday: {
        //   start: "",
        //   end: "",
        // },

        // thursday: {
        //   start: "",
        //   end: "",
        // },

        // friday: {
        //   start: "",
        //   end: "",
        // },

        // saturday: {
        //   start: "",
        //   end: "",
        // },

        // sunday: {
        //   start: "",
        //   end: "",
        // },
      },
    };
  },
  methods: {
    CreateNewOffice() {
      adminService.CreateNewOffice(this.office)
      .then((response) =>{
        if (response.status === 200 || response.status === 201) {
          alert("Office Has Been Successfully Created");
          this.$router.push("adminHome");
        }
        if (response.status === 400) {
          alert("Error 400: Bad Request. Please Try Again.");
          this.$router.push("adminHome");
        }
        if (response.status === 500) {
          alert("Oops! Something went wrong in the back end.");
          this.$router.push("adminHome");
        }
      })
    }
  },
};
</script>

<style>
.createNewOfficeFormText{
  text-align: right;
}
.createOfficeForm{
    border: 2px solid black;
    text-align: right;
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
        margin-left:200px;
        margin-top:150px ;

}
</style>