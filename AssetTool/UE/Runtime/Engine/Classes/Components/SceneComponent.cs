namespace AssetTool
{
    [JsonAsset("SceneComponent")]
    public class USceneComponent : UActorComponent
    {
        public FBool bIsCooked;
        public FBoxSphereBounds Bounds;

        [Location("void USceneComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            bool bComputeBoundsOnceForGame = Members.TryGetValue("bool 'bComputeBoundsOnceForGame'", out object value) && bool.Parse(value.ToString());

            if (bComputeBoundsOnceForGame)
            {
                if (transfer.Supports.SerializeSceneComponentStaticBounds)
                {
                    transfer.Move(ref bIsCooked);
                    if (bIsCooked)
                    {
                        transfer.Move(ref Bounds);
                    }
                }
            }

            return this;
        }
    }
}