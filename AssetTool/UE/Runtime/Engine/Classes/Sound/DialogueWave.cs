namespace AssetTool
{
    [JsonAsset("DialogueWave")]
    public class UDialogueWave : UObject
    {
        public bool bCooked;

        [Location("void UDialogueWave::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref bCooked);
            return this;
        }
    }
}