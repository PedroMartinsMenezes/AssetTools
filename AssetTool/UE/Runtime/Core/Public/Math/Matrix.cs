namespace AssetTool
{
    public struct FMatrix44f
    {
        public float M11;
        public float M12;
        public float M13;
        public float M14;
        public float M21;
        public float M22;
        public float M23;
        public float M24;
        public float M31;
        public float M32;
        public float M33;
        public float M34;
        public float M41;
        public float M42;
        public float M43;
        public float M44;

        public FMatrix44f Move(Transfer transfer)
        {
            transfer.Move(ref M11);
            transfer.Move(ref M12);
            transfer.Move(ref M13);
            transfer.Move(ref M14);
            transfer.Move(ref M21);
            transfer.Move(ref M22);
            transfer.Move(ref M23);
            transfer.Move(ref M24);
            transfer.Move(ref M31);
            transfer.Move(ref M32);
            transfer.Move(ref M33);
            transfer.Move(ref M34);
            transfer.Move(ref M41);
            transfer.Move(ref M42);
            transfer.Move(ref M43);
            transfer.Move(ref M44);
            return this;
        }
    }

    public struct FMatrix44d
    {
        public double M11;
        public double M12;
        public double M13;
        public double M14;
        public double M21;
        public double M22;
        public double M23;
        public double M24;
        public double M31;
        public double M32;
        public double M33;
        public double M34;
        public double M41;
        public double M42;
        public double M43;
        public double M44;

        public FMatrix44d Move(Transfer transfer)
        {
            transfer.Move(ref M11);
            transfer.Move(ref M12);
            transfer.Move(ref M13);
            transfer.Move(ref M14);
            transfer.Move(ref M21);
            transfer.Move(ref M22);
            transfer.Move(ref M23);
            transfer.Move(ref M24);
            transfer.Move(ref M31);
            transfer.Move(ref M32);
            transfer.Move(ref M33);
            transfer.Move(ref M34);
            transfer.Move(ref M41);
            transfer.Move(ref M42);
            transfer.Move(ref M43);
            transfer.Move(ref M44);
            return this;
        }
    }
}
