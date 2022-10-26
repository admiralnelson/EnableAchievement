Imports System.Reflection
Imports HarmonyLib
Imports StoryMode.GameComponents.CampaignBehaviors
Imports TaleWorlds.CampaignSystem
Imports TaleWorlds.Core

Public Module EnableAchievement
    Public Sub DoIt(gameStarterObject As IGameStarter)
        Task.Delay(1000 * 1).ContinueWith(
            Sub()
                Dim campaignStarter = CType(gameStarterObject, CampaignGameStarter)
                Dim achievementManagerBehaviour = campaignStarter.CampaignBehaviors.Where(Function(x) x.StringId.Contains("AchievementsCampaignBehavior")).FirstOrDefault()
                Dim theType = GetType(AchievementsCampaignBehavior)
                Dim deactivateAchievements = theType.GetProperty("_deactivateAchievements", BindingFlags.NonPublic Or BindingFlags.Instance)
                If IsNothing(deactivateAchievements) Then Exit Sub
                deactivateAchievements.SetValue(achievementManagerBehaviour, False)
            End Sub)
    End Sub
    <HarmonyPatch(GetType(AchievementsCampaignBehavior), "CheckAchievementSystemActivity")>
    Public Class CheckAchievementSystemActivity
        Public Shared Function Prefix(ByRef __result As Boolean) As Boolean
            __result = True
            Return False
        End Function
    End Class
End Module
