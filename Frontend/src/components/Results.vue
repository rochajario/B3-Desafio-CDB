<template>
  <v-card  v-if="this.result.fullfilled" class="mx-auto my-12" max-width="500">
    <v-card-title>Resultado</v-card-title>
    <v-divider class="mx-4"></v-divider>
    <v-simple-table class="mt-2">
      <template v-slot:default>
        <thead>
          <tr>
            <th class="text-left">Valor Inicial</th>
            <th class="text-center">Meses</th>
            <th class="text-center">Rend. Bruto</th>
            <th class="text-right">Rend. Líquido</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td class="text-left">R$ {{ result.object.initialValue.toFixed(2) }}</td>
            <td class="text-center">{{ result.object.monthsCommited }}</td>
            <td class="text-center">R$ {{ result.object.grossProfit.toFixed(2) }}</td>
            <td class="text-right">R$ {{ result.object.clearProfit.toFixed(2) }}</td>
          </tr>
        </tbody>
        <tfoot>
          <tr>
            <th colspan="2">Valor Final</th>
            <td colspan="2" class="text-right">
              R$ {{ result.object.finalValue.toFixed(2) }}
            </td>
          </tr>
        </tfoot>
      </template>
    </v-simple-table>
  </v-card>
</template>

<script>
export default {
  props: {
    result: {
      type: Object ,
      required: true,
    },
  },
};
</script>