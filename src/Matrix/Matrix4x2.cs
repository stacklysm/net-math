namespace NetMath.Matrix
{
    public struct Matrix4x2
    {
        public float M11 { get; set;}
        public float M12 { get; set;}
        public float M21 { get; set;}
        public float M22 { get; set;}
        public float M31 { get; set;}
        public float M32 { get; set;}
        public float M41 { get; set;}
        public float M42 { get; set;}

        public Matrix4x2(
            float m11, float m12,
            float m21, float m22,
            float m31, float m32,
            float m41, float m42)
        {
            this.M11 = m11;
            this.M12 = m12;
            this.M21 = m21;
            this.M22 = m22;
            this.M31 = m31;
            this.M32 = m32;
            this.M41 = m41;
            this.M42 = m42;
        }
    }
}