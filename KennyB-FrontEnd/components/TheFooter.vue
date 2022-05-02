<template>
  <v-footer
    class="footer"
    color="accent darken-1"
    padless
  >
    <v-row
      justify="center"
    >
      <v-btn
        v-for="link in links"
        :key="link"
        color="white"
        text
        rounded
        class="my-2"
      >
        {{ link }}
      </v-btn>
      <v-col
        class="accent darken-2 py-4 text-center white--text"
        cols="12"
      >
        {{ new Date().getFullYear() }} — <strong>Kenny Boufadene</strong>
      </v-col>
    </v-row>
  </v-footer>
</template>
<script>
export default {
  data () {
    return {
      links: [
        'Contact',
        'Other'
      ]
    }
  }
}
</script>
<style>
.footer {
    position: fixed;
    height: 50px;
    bottom: 0px;
    left: 0vh;
    right: 0vh;
    margin-bottom: 40px;
      margin-top: 5vh;
}
</style>
