namespace AssetTool
{
    public struct DMatrix4x4
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

        public DMatrix4x4 Move(Transfer transfer)
        {
            if (Supports.UEVer(EUnrealEngineObjectUE5Version.LARGE_WORLD_COORDINATES))
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
            }
            else
            {
                transfer.MoveFloat(ref M11);
                transfer.MoveFloat(ref M12);
                transfer.MoveFloat(ref M13);
                transfer.MoveFloat(ref M14);
                transfer.MoveFloat(ref M21);
                transfer.MoveFloat(ref M22);
                transfer.MoveFloat(ref M23);
                transfer.MoveFloat(ref M24);
                transfer.MoveFloat(ref M31);
                transfer.MoveFloat(ref M32);
                transfer.MoveFloat(ref M33);
                transfer.MoveFloat(ref M34);
                transfer.MoveFloat(ref M41);
                transfer.MoveFloat(ref M42);
                transfer.MoveFloat(ref M43);
                transfer.MoveFloat(ref M44);
            }
            return this;
        }
    }
}
