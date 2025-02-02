//namespace AssetTool
//{
//    public class DebugTransferWriter2 : DebugTransferWriter
//    {
//        public DebugTransferWriter2(BinaryWriter writer) : base(writer) { }

//        static DebugTransferWriter2()
//        {
//            File.WriteAllText("C:/Temp/DebugTransferWriter2.log", "");
//        }

//        protected override void Log(long position1, long position2)
//        {
//            if (position2 > position1)
//            {
//                byte[] bytes = new byte[position2 - position1];
//                Position = position1;
//                writer.Write(bytes, 0, (int)(position2 - position1));
//                string content = BitConverter.ToString(bytes).Replace("-", "");
//                File.AppendAllLines("C:/Temp/DebugTransferWriter2.log", [content]);
//            }
//        }

//        protected override T Log<T>(Func<T> func)
//        {
//            long position1 = Position;
//            T result = func();
//            long position2 = Position;
//            if (Position > position1)
//            {
//                byte[] bytes = new byte[position2 - position1];
//                Position = position1;
//                writer.Write(bytes, 0, (int)(position2 - position1));
//                string content = BitConverter.ToString(bytes).Replace("-", "");
//                File.AppendAllLines("C:/Temp/DebugTransferWriter2.log", [content]);
//            }
//            return result;
//        }
//    }
//}
