<template>
<div>
    <div class="appointmentCard">
        Dr. {{appointment.doctorFirstName}} {{appointment.doctorLastName}}<br/>
        Office Name: {{appointment.officeName}}<br/>
        <br/>
        <p><b>Appointment Info</b></p>
        Date: {{appointment.date}}<br/>
        Time: {{appointment.time}}<br/>
        Virtual: {{appointment.virtual}}<br/>
        Message: {{appointment.message}}<br/>
        Status: {{appointment.status}}<br/>
    </div>
</div>
</template>

<script>
export default {
    props: {
        appointment: Object,
    }
}
</script>



<style >
.appointmentCard {

    border: 2px solid black;
    border-radius: 10px;
    width: 275px;
    background-image: linear-gradient(to bottom right, rgb(255, 255, 255), rgb(218, 236, 53));
    height: cover;
    padding: 10px;
    margin: 50px;
    margin-left: 250px;
}

.appointmentTitle {
  margin: 50px;
}

</style>