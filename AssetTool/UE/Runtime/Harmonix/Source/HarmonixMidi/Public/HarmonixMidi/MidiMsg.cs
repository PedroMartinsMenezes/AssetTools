namespace AssetTool
{
    public class FMidiMsg : ITransferible
    {
        public EType Type;
        public uint8 Status;
        public uint8 Data1;
        public uint8 Data2;
        public uint8 MicsPerQuarterNoteH;
        public uint16 MicsPerQuarterNoteL;
        public uint8 Numerator;
        public uint8 Denominator;
        public uint8 TextType;
        public uint16 TextIndex;

        [Location("bool FMidiMsg::Serialize(FArchive& Archive)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Type);
            switch (Type)
            {
                case EType.Std:
                    transfer.Move(ref Status);
                    transfer.Move(ref Data1);
                    transfer.Move(ref Data2);
                    break;
                case EType.Tempo:
                    transfer.Move(ref MicsPerQuarterNoteH);
                    transfer.Move(ref MicsPerQuarterNoteL);
                    break;
                case EType.TimeSig:
                    transfer.Move(ref Numerator);
                    transfer.Move(ref Denominator);
                    break;
                case EType.Text:
                    transfer.Move(ref TextType);
                    transfer.Move(ref TextIndex);
                    break;
            }
            return this;
        }

        public enum EType : uint8
        {
            Std = 1,
            Tempo = 2,
            TimeSig = 4,
            Text = 8,
            Runtime = 16
        }
    }
}
