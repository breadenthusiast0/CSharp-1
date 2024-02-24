class Coche {
    private Motor motor;
    private String marca;
    private String modelo;
    private double precio_acumulado_averias;

    public Coche(String marca, String modelo) {
        this.marca = marca;
        this.modelo = modelo;
        this.precio_acumulado_averias = 0.0;
    }

    public Motor getMotor() {
        return motor;
    }

    public void setMotor(Motor motor) {
        this.motor = motor;
    }

    public String getMarca() {
        return marca;
    }

    public String getModelo() {
        return modelo;
    }

    public double getPrecio_acumulado_averias() {
        return precio_acumulado_averias;
    }

    public void acumularAveria(double importe) {
        this.precio_acumulado_averias += importe;
    }
}