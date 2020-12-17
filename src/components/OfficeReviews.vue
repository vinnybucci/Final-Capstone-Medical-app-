<template>
<div>
<div v-for="review in reviews" v-bind:key="review.reviewId" v-bind:review="review">
<review-card/>

</div>
</template>

<script>
import reviewCard from "../components/ReviewCard"
export default {

    components: reviewCard,

    data(){
        return{
            reviews: []
        }
    }

}
</script>

<style >

</style>