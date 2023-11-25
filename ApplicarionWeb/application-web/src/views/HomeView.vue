<script setup lang="ts">
import { onMounted,ref} from 'vue';
import DataTable from 'primevue/datatable'
import Column from 'primevue/column'

  
  let clientList = ref([])

  const getClients  = async () => {
    const response =await fetch('http://localhost:5218/api/clients')
    const data = await response.json()
    clientList.value = data.clientList
  }

  onMounted(async()=>{
    await getClients()
  })
</script>

<template>
  
  <div class="grid">
    <div class="col-12" style="text-align: center;">
      <h2 style="color: rgb(81, 81, 91); text-decoration: underline;">Lista de clientes</h2>
    </div>
  </div>

  <div class="mb-3"></div>
  <div class="grid">
    <div class="col-12">
      <DataTable :value="clientList">
        <Column field="id_cliente" header="Numero Cliente"></Column>
        <Column field="nombre" header="Nombre"></Column>
        <Column field="ciudad" header="Provincia"></Column>
        <Column field="provincia" header="Provincia"></Column>
        <Column field="zona" header="Zona"></Column>
      </DataTable>
    </div>
  </div>
</template>
