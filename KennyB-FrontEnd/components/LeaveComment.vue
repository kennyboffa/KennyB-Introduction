<template>
  <div>
    <br>
    <p style="text-align:center; font-style:italic;">
      Just a little comment section to utilize a database
    </p>
    <form class="comment-container">
      <v-text-field
        v-model="name"
        label="Name"
        required
      />
      <v-text-field
        v-model="email"
        label="E-mail"
        required
      />
      <v-textarea
        v-model="comment"
        color="teal"
        label="Comment"
      >
        <div>
          Comment
        </div>
      </v-textarea>
      <v-btn
        class="mr-4"
        @click="submit"
      >
        submit
      </v-btn>
      <v-btn @click="clear">
        clear
      </v-btn>
    </form>
  </div>
</template>

<script>
export default {

  data () {
    return {
      name: '',
      email: '',
      comment: '',

      com: undefined
    }
  },

  methods: {
    submit () {
      // this.$v.$touch()

      const newComment = {
        name: this.name,
        email: this.email,
        commentContent: this.comment
      }
      console.log(newComment)
      this.$axios
        .post('/comment', newComment)
        .then((res) => {
          this.com = res.data
          console.log(res)
        })
      this.name = ''
      this.email = ''
      this.comment = ''
    },
    clear () {
      this.name = ''
      this.email = ''
      this.comment = ''
    }
  }
}
</script>

<style>
/* .comment{
    margin:5vh;
    padding:3.5vh;

} */
.comment-container{

  margin:10% 25% 5% 25%;
    padding:3vh;
    border-style: solid;
    border-color: rgb(177, 187, 196);
    border-radius: 5vh;
}
@media screen and (max-width: 600px) {

  .comment-container{

  margin:5% 15% 5% 15%;
    padding:3vh;
    border-style: solid;
    border-color: rgb(177, 187, 196);
    border-radius: 5vh;
  }
}
</style>
