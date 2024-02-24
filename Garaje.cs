class Garaje {
    private Coche coche;
    private String nombre_averia_asociada;
    private int num_coches_atendidos;

    public Garaje() {
        this.coche = null;
        this.nombre_averia_asociada = "";
        this.num_coches_atendidos = 0;
    }

    public bool aceptarCoche(Coche coche, String averia_asociada) {
        if (this.coche == null) {
            this.coche = coche;
            this.nombre_averia_asociada = averia_asociada;
            this.num_coches_atendidos++;
            return true;
        } else {
            return false;
        }
    }

    public void devolverCoche() {
        this.coche = null;
        this.nombre_averia_asociada = "";
    }

    public int getNum_coches_atendidos() {
        return num_coches_atendidos;
    }
}