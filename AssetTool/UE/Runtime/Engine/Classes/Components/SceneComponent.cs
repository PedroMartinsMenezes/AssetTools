using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonAsset("SceneComponent")]
    public class USceneComponent : UActorComponent
    {
        public FBool bIsCooked;
        public FBoxSphereBounds Bounds;
        [JsonIgnore] public bool bComputeBoundsOnceForGame;

        [Location("void USceneComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            if (Members.FirstOrDefault(x => x.Key.Contains("bComputeBoundsOnceForGame")) is var value && value.Value is { })
            {
                bComputeBoundsOnceForGame = Convert.ToBoolean(value.Value.ToString());
            }

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