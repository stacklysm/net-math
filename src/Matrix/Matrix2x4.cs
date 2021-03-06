namespace NetMath.Matrix
{
    public struct Matrix2x4
    {
        public float M11 { get; set; }
        public float M12 { get; set; }
        public float M13 { get; set; }
        public float M14 { get; set; }
        public float M21 { get; set; }
        public float M22 { get; set; }
        public float M23 { get; set; }
        public float M24 { get; set; }

        public float this[int row, int column]
        {
            get
            {
                if (row >= 1 and <= 2 && column >= 1 and <= 4)
                {
                    if (row == 1 && column == 1) return M11;
                    if (row == 1 && column == 2) return M12;
                    if (row == 1 && column == 3) return M13;
                    if (row == 1 && column == 4) return M14;
                    if (row == 2 && column == 1) return M21;
                    if (row == 2 && column == 2) return M22;
                    if (row == 2 && column == 3) return M23;
                    if (row == 2 && column == 4) return M24;
                }
            }

            set
            {
                if (row >= 1 and <= 2 && column >= 1 and <= 4)
                {
                    if (row == 1 && column == 1) M11 = value;
                    if (row == 1 && column == 2) M12 = value;
                    if (row == 1 && column == 3) M13 = value;
                    if (row == 1 && column == 4) M14 = value;
                    if (row == 2 && column == 1) M21 = value;
                    if (row == 2 && column == 2) M22 = value;
                    if (row == 2 && column == 3) M23 = value;
                    if (row == 2 && column == 4) M24 = value;
                }
            }
        }

        public Matrix2x3(
            float m11, float m12, float m13, float m14,
            float m21, float m22, float m23, float m24)
        {
            this.M11 = m11;
            this.M12 = m12;
            this.M13 = m13;
            this.M14 = m14;
            this.M21 = m21;
            this.M22 = m22;
            this.M23 = m23;
            this.M24 = m24;
        }
    }
}