<template>
  <div>{{ comments }}</div>
</template>

<script>
export default {

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

<style>

</style>
