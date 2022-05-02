<template>
  <div>
    <div
      v-for="comment in comments"
      :key="comment.id"
    >
      <v-list
        flat
        class="comment-container"
        color="accent"
        elevation="10"
        outlined
      >
        <small>On //insert date//{{ comment.date }} {{ comment.name }} wrote:</small>
        <v-list-item class="comment-content">
          {{ comment.commentContent }}
        </v-list-item>
      </v-list>
    </div>
  </div>
</template>

<script>
export default {

  //   Add logic to remove comments
  // add lgoc to show date when comment was posted

  data () {
    return {

      comments: []
    }
  },
  mounted () {
    this.getComments()
  },
  methods: {

    getComments () {
      this.$axios
        .get('/comment')
        .then((res) => {
          this.comments = res.data
        })
    }
  }

}
</script>

<style scoped>
.comment-container{

  margin:7vh;
      border: 50px, solid, rgb(196, 62, 62) ;
  /*background-color:rgb(69, 129, 168); */
      border-radius: 50px;
}
</style>
