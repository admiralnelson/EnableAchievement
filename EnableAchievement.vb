Imports System.Reflection
Imports HarmonyLib
Imports StoryMode
Imports StoryMode.GameComponents.CampaignBehaviors
Imports TaleWorlds
Imports TaleWorlds.CampaignSystem
Imports TaleWorlds.CampaignSystem.Actions
Imports TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfSettlementAction
Imports TaleWorlds.CampaignSystem.Actions.KillCharacterAction
Imports TaleWorlds.CampaignSystem.Election
Imports TaleWorlds.CampaignSystem.Issues
Imports TaleWorlds.CampaignSystem.MapEvents
Imports TaleWorlds.CampaignSystem.Party
Imports TaleWorlds.CampaignSystem.Settlements
Imports TaleWorlds.CampaignSystem.Settlements.Buildings
Imports TaleWorlds.CampaignSystem.Settlements.Workshops
Imports TaleWorlds.Core
Imports TaleWorlds.Library

Public Module EnableAchievement
    Public Sub ShowToastMessage(str As String)
        MBInformationManager.AddQuickInformation(New Localization.TextObject(str))
    End Sub

    Public Sub DoIt(gameStarterObject As IGameStarter)
        Try
            Dim campaignStarter = CType(gameStarterObject, CampaignGameStarter)
            Dim achievementManagerBehaviour = campaignStarter.CampaignBehaviors.Where(Function(x) x.StringId.Contains("AchievementsCampaignBehavior")).FirstOrDefault()
            If IsNothing(achievementManagerBehaviour) Then
                campaignStarter.AddBehavior(New AchievementsCampaignBehavior())
            End If
            Task.Delay(1000 * 2).ContinueWith(
                Sub()
                    Dim theType = GetType(AchievementsCampaignBehavior)
                    Dim deactivateAchievements = theType.GetProperty("_deactivateAchievements", BindingFlags.NonPublic Or BindingFlags.Instance)
                    If IsNothing(deactivateAchievements) Then Exit Sub
                    deactivateAchievements.SetValue(achievementManagerBehaviour, False)
                    ShowToastMessage("Hello from Achievements Enabler!")
                End Sub)
        Catch ex As InvalidCastException
            Print("achievement enabler: there's no achievement in custom battle :^)")
        End Try
    End Sub
    <HarmonyPatch(GetType(AchievementsCampaignBehavior), "CheckAchievementSystemActivity")>
    Public Class CheckAchievementSystemActivity
        Public Shared Function Prefix(ByRef __result As Boolean) As Boolean
            __result = True
            Return False
        End Function
    End Class

    ''' <summary>
    ''' Taleworlds momentos
    ''' </summary>
    <HarmonyPatch(GetType(AchievementsCampaignBehavior), "SyncData")>
    Public Class ForceSyncDataAchievementsToTrue
        Public Shared Function Prefix(ByRef __instance As AchievementsCampaignBehavior, dataStore As IDataStore) As Boolean
            Try
                Dim deactivateAchievements As Boolean = False
                dataStore.SyncData("_deactivateAchievements", deactivateAchievements)

                Dim theType = GetType(AchievementsCampaignBehavior)
                Dim deactivateAchievementsField = theType.GetField("_deactivateAchievements", BindingFlags.NonPublic Or BindingFlags.Instance)
                If Not IsNothing(deactivateAchievementsField) Then
                    deactivateAchievementsField.SetValue(__instance, False)
                End If
            Catch ex As Exception
                Console.WriteLine("Error in Prefix method: " & ex.Message)
            End Try
            Return False
        End Function
    End Class

    ''' <summary>
    ''' Vanilla RegisterEvents ends by subscribing to StoryModeEvents, which are null outside
    ''' story mode. Let vanilla register everything and swallow only that failure.
    ''' </summary>
    <HarmonyPatch(GetType(AchievementsCampaignBehavior), "RegisterEvents")>
    Public Class RegisterEvents
        Public Shared Function Finalizer(__exception As Exception) As Exception
            If TypeOf __exception Is NullReferenceException AndAlso IsNothing(StoryModeManager.Current) Then
                Return Nothing
            End If
            Return __exception
        End Function
    End Class
End Module
