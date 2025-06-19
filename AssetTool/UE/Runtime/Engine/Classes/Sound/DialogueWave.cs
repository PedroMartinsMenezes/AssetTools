namespace AssetTool
{
    [JsonAsset("DialogueWave")]
    public class UDialogueWave : UObject
    {
        public FBool bCooked;

        [Location("void UDialogueWave::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref bCooked);
            return this;
        }
    }
}