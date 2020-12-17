<template>

<div>
 
  <doctors-offices/>
</div>
</template>

<script>
import DoctorsOffices from "../components/DoctorsOffices"
export default {
    components: {
        DoctorsOffices
    },
    computed:{
       theBook(){
      return  this.$store.state.offices.filter(book =>  {
          return book.isbn === this.$route.params.userId;
      });
    },
    }

}
</script>

<style >

</style>