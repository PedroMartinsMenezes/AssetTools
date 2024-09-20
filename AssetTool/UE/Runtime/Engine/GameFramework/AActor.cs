namespace AssetTool
{
    [JsonAsset("AActor")]
    [Location("void AActor::Serialize(FArchive& Ar)")]
    public class AActor : UObject
    {
        public FBool bIsCooked;
        public FString ActorLabel;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref bIsCooked);
            if (bIsCooked.Value)
            {
                transfer.Move(ref ActorLabel);
            }

            return this;
        }
    }
}