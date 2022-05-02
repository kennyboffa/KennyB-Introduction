<template>
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
.comment{
    margin:5vh;
    padding:3.5vh;

}
.comment-container{
    margin:10vh;
    padding:3vh;
    border-style: solid;
    border-color: rgb(177, 187, 196);
    border-radius: 5vh;
}
</style>
