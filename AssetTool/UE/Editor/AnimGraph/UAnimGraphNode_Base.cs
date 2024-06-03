namespace AssetTool
{
    public class UAnimGraphNode_Base : UK2Node
    {
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
            /*
            Super::Serialize(Ar);

			Ar.UsingCustomVersion(FReleaseObjectVersion::GUID);

			if (Ar.IsLoading())
			{
				if (Ar.CustomVer(FReleaseObjectVersion::GUID) < FReleaseObjectVersion::AnimationGraphNodeBindingsDisplayedAsPins)
				{
					// Push any bindings to optional pins
					bool bPushedBinding = false;
					for(const TPair<FName, FAnimGraphNodePropertyBinding>& BindingPair : PropertyBindings)
					{
						for(FOptionalPinFromProperty& OptionalPin : ShowPinForProperties)
						{
							if(OptionalPin.bCanToggleVisibility && !OptionalPin.bShowPin && OptionalPin.PropertyName == BindingPair.Key)
							{
								OptionalPin.bShowPin = true;
								bPushedBinding = true;
							}
						}
					}

					if(bPushedBinding)
					{
						FOptionalPinManager::EvaluateOldShownPins(ShowPinForProperties, OldShownPins, this);
					}
				}
			}
			*/
        }
    }
}