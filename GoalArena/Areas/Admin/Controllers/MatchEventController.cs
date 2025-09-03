using GoalArena.Models;
using GoalArena.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoalArena.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MatchEventController : Controller
    {
        private readonly IMatchEventRepository _matchEventRepository;
        private readonly ImatchRepository _matchRepository;
        private readonly ITeamRepository _teamRepository;
        private readonly IPlayerRepository _playerRepository;

        public MatchEventController(
            IMatchEventRepository matchEventRepository,
            ImatchRepository matchRepository,
            ITeamRepository teamRepository,
            IPlayerRepository playerRepository)
        {
            _matchEventRepository = matchEventRepository;
            _matchRepository = matchRepository;
            _teamRepository = teamRepository;
            _playerRepository = playerRepository;
        }

        
        public async Task<IActionResult> Index(int? matchId)
        {
            IEnumerable<MatchEvent> events;

            if (matchId.HasValue)
            {
                
                events = await _matchEventRepository.GetAsync(
                    e => e.MatchId == matchId.Value,
                    includes: [e => e.Match, e => e.Team, e => e.Player]);

                ViewBag.MatchId = matchId;
                var match = await _matchRepository.GetOneAsync(
                    m => m.MatchId == matchId.Value,
                    includes: [m => m.HomeTeam, m => m.AwayTeam]);

                if (match != null)
                {
                    ViewBag.MatchName = $"{match.HomeTeam?.Name} vs {match.AwayTeam?.Name}";
                }
            }
            else
            {
               
                events = await _matchEventRepository.GetAsync(
                    includes: [e => e.Match, e => e.Team, e => e.Player]);
            }

            return View(events);
        }

       
        public async Task<IActionResult> Create(int matchId)
        {
            var match = await _matchRepository.GetOneAsync(
                m => m.MatchId == matchId,
                includes: [m => m.HomeTeam, m => m.AwayTeam]);

            if (match == null) return NotFound();

            
            ViewBag.Match = match;

            ViewBag.Teams = new List<SelectListItem>
            {
                new SelectListItem { Value = match.HomeTeamId.ToString(), Text = match.HomeTeam?.Name ?? "Home Team" },
                new SelectListItem { Value = match.AwayTeamId.ToString(), Text = match.AwayTeam?.Name ?? "Away Team" }
            };

            var homePlayers = await _playerRepository.GetAsync(p => p.TeamId == match.HomeTeamId);
            var awayPlayers = await _playerRepository.GetAsync(p => p.TeamId == match.AwayTeamId);

            ViewBag.Players = homePlayers.Concat(awayPlayers)
                .Select(p => new SelectListItem
                {
                    Value = p.PlayerId.ToString(),
                    Text = $"{p.Name} ({(p.TeamId == match.HomeTeamId ? match.HomeTeam?.Name : match.AwayTeam?.Name)})"
                })
                .ToList();

            ViewBag.EventTypes = Enum.GetValues(typeof(EventType))
                .Cast<EventType>()
                .Select(e => new SelectListItem { Value = ((int)e).ToString(), Text = e.ToString() })
                .ToList();

            ViewBag.GoalTypes = Enum.GetValues(typeof(GoalType))
                .Cast<GoalType>()
                .Select(g => new SelectListItem { Value = ((int)g).ToString(), Text = g.ToString() })
                .ToList();

            return View(new MatchEvent { MatchId = matchId });
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MatchEvent matchEvent)
        {
            if (ModelState.IsValid)
            {
                await _matchEventRepository.CreateAsync(matchEvent);
                await _matchEventRepository.CommitAsync();

               
                await UpdateMatchBasedOnEvent(matchEvent);

                return RedirectToAction("Details", "Match", new { id = matchEvent.MatchId });
            }

          
            var match = await _matchRepository.GetOneAsync(
                m => m.MatchId == matchEvent.MatchId,
                includes: [m => m.HomeTeam, m => m.AwayTeam]);

            ViewBag.Match = match;

            ViewBag.Teams = new List<SelectListItem>
            {
                new SelectListItem { Value = match.HomeTeamId.ToString(), Text = match.HomeTeam?.Name ?? "Home Team" },
                new SelectListItem { Value = match.AwayTeamId.ToString(), Text = match.AwayTeam?.Name ?? "Away Team" }
            };

            var homePlayers = await _playerRepository.GetAsync(p => p.TeamId == match.HomeTeamId);
            var awayPlayers = await _playerRepository.GetAsync(p => p.TeamId == match.AwayTeamId);

            ViewBag.Players = homePlayers.Concat(awayPlayers)
                .Select(p => new SelectListItem
                {
                    Value = p.PlayerId.ToString(),
                    Text = $"{p.Name} ({(p.TeamId == match.HomeTeamId ? match.HomeTeam?.Name : match.AwayTeam?.Name)})"
                })
                .ToList();

            ViewBag.EventTypes = Enum.GetValues(typeof(EventType))
                .Cast<EventType>()
                .Select(e => new SelectListItem { Value = ((int)e).ToString(), Text = e.ToString() })
                .ToList();

            ViewBag.GoalTypes = Enum.GetValues(typeof(GoalType))
                .Cast<GoalType>()
                .Select(g => new SelectListItem { Value = ((int)g).ToString(), Text = g.ToString() })
                .ToList();

            return View(matchEvent);
        }

       
        public async Task<IActionResult> Edit(int id)
        {
            var matchEvent = await _matchEventRepository.GetOneAsync(e => e.Id == id);
            if (matchEvent == null) return NotFound();

            var match = await _matchRepository.GetOneAsync(
                m => m.MatchId == matchEvent.MatchId,
                includes: [m => m.HomeTeam, m => m.AwayTeam]);

           
            ViewBag.Match = match;

            ViewBag.Teams = new List<SelectListItem>
            {
                new SelectListItem { Value = match.HomeTeamId.ToString(), Text = match.HomeTeam?.Name ?? "Home Team" },
                new SelectListItem { Value = match.AwayTeamId.ToString(), Text = match.AwayTeam?.Name ?? "Away Team" }
            };

            var homePlayers = await _playerRepository.GetAsync(p => p.TeamId == match.HomeTeamId);
            var awayPlayers = await _playerRepository.GetAsync(p => p.TeamId == match.AwayTeamId);

            ViewBag.Players = homePlayers.Concat(awayPlayers)
                .Select(p => new SelectListItem
                {
                    Value = p.PlayerId.ToString(),
                    Text = $"{p.Name} ({(p.TeamId == match.HomeTeamId ? match.HomeTeam?.Name : match.AwayTeam?.Name)})"
                })
                .ToList();

            ViewBag.EventTypes = Enum.GetValues(typeof(EventType))
                .Cast<EventType>()
                .Select(e => new SelectListItem { Value = ((int)e).ToString(), Text = e.ToString() })
                .ToList();

            ViewBag.GoalTypes = Enum.GetValues(typeof(GoalType))
                .Cast<GoalType>()
                .Select(g => new SelectListItem { Value = ((int)g).ToString(), Text = g.ToString() })
                .ToList();

            return View(matchEvent);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MatchEvent matchEvent)
        {
            if (id != matchEvent.Id) return NotFound();

            if (ModelState.IsValid)
            {
               
                var originalEvent = await _matchEventRepository.GetOneAsync(e => e.Id == id);

                _matchEventRepository.Edit(matchEvent);
                await _matchEventRepository.CommitAsync();

              
                if (originalEvent != null &&
                    (originalEvent.EventType != matchEvent.EventType ||
                     originalEvent.TeamId != matchEvent.TeamId ||
                     originalEvent.GoalType != matchEvent.GoalType))
                {
                   
                    await RevertMatchEventEffect(originalEvent);

                  
                    await UpdateMatchBasedOnEvent(matchEvent);
                }

                return RedirectToAction("Details", "Match", new { id = matchEvent.MatchId });
            }

           
            var match = await _matchRepository.GetOneAsync(
                m => m.MatchId == matchEvent.MatchId,
                includes: [m => m.HomeTeam, m => m.AwayTeam]);

            ViewBag.Match = match;

            ViewBag.Teams = new List<SelectListItem>
            {
                new SelectListItem { Value = match.HomeTeamId.ToString(), Text = match.HomeTeam?.Name ?? "Home Team" },
                new SelectListItem { Value = match.AwayTeamId.ToString(), Text = match.AwayTeam?.Name ?? "Away Team" }
            };

            var homePlayers = await _playerRepository.GetAsync(p => p.TeamId == match.HomeTeamId);
            var awayPlayers = await _playerRepository.GetAsync(p => p.TeamId == match.AwayTeamId);

            ViewBag.Players = homePlayers.Concat(awayPlayers)
                .Select(p => new SelectListItem
                {
                    Value = p.PlayerId.ToString(),
                    Text = $"{p.Name} ({(p.TeamId == match.HomeTeamId ? match.HomeTeam?.Name : match.AwayTeam?.Name)})"
                })
                .ToList();

            ViewBag.EventTypes = Enum.GetValues(typeof(EventType))
                .Cast<EventType>()
                .Select(e => new SelectListItem { Value = ((int)e).ToString(), Text = e.ToString() })
                .ToList();

            ViewBag.GoalTypes = Enum.GetValues(typeof(GoalType))
                .Cast<GoalType>()
                .Select(g => new SelectListItem { Value = ((int)g).ToString(), Text = g.ToString() })
                .ToList();

            return View(matchEvent);
        }

       
        public async Task<IActionResult> Delete(int id)
        {
            var matchEvent = await _matchEventRepository.GetOneAsync(
                e => e.Id == id,
                includes: [e => e.Match, e => e.Team, e => e.Player]);

            if (matchEvent == null) return NotFound();

            return View(matchEvent);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matchEvent = await _matchEventRepository.GetOneAsync(e => e.Id == id);
            if (matchEvent == null) return NotFound();

            int matchId = matchEvent.MatchId;

           
            await RevertMatchEventEffect(matchEvent);

            _matchEventRepository.Delete(matchEvent);
            await _matchEventRepository.CommitAsync();

            return RedirectToAction("Details", "Match", new { id = matchId });
        }

       
        private async Task UpdateMatchBasedOnEvent(MatchEvent matchEvent)
        {
          
            var match = await _matchRepository.GetOneAsync(m => m.MatchId == matchEvent.MatchId);

            if (match == null) return;

            bool matchChanged = false;

          
            switch (matchEvent.EventType)
            {
                case EventType.Goal:
                   
                    matchChanged = UpdateMatchScore(match, matchEvent);
                    break;

                case EventType.StartFirstHalf:
                    match.Status = MatchStatus.InProgress;
                    matchChanged = true;
                    break;

                case EventType.EndFirstHalf:
                    match.Status = MatchStatus.HalfTime;
                    matchChanged = true;
                    break;

                case EventType.StartSecondHalf:
                    match.Status = MatchStatus.InProgress;
                    matchChanged = true;
                    break;

                case EventType.EndSecondHalf:
                   
                    if (match.HomeScore != match.AwayScore)
                    {
                        match.Status = MatchStatus.Completed;
                        match.EndTime = DateTime.Now;
                        matchChanged = true;
                    }
                    
                    else
                    {
                        match.Status = MatchStatus.Completed;
                        match.EndTime = DateTime.Now;
                        matchChanged = true;
                      
                    }
                    break;

                case EventType.ExtraTime:
                    match.Status = MatchStatus.ExtraTime;
                    matchChanged = true;
                    break;

                case EventType.PenaltyShootout:
                    match.Status = MatchStatus.Penalties;
                    matchChanged = true;
                    break;
            }

           
            if (matchChanged)
            {
               
                UpdateMatchResult(match);

                _matchRepository.Edit(match);
                await _matchRepository.CommitAsync();
            }
        }

       
        private async Task RevertMatchEventEffect(MatchEvent matchEvent)
        {
            var match = await _matchRepository.GetOneAsync(m => m.MatchId == matchEvent.MatchId);

            if (match == null) return;

            bool matchChanged = false;

            if (matchEvent.EventType == EventType.Goal)
            {
               
                bool isOwnGoal = matchEvent.GoalType == GoalType.OwnGoal;

                if (isOwnGoal)
                {
                   
                    if (matchEvent.TeamId == match.HomeTeamId && match.AwayScore.HasValue && match.AwayScore > 0)
                    {
                        match.AwayScore--;
                        matchChanged = true;
                    }
                    else if (matchEvent.TeamId == match.AwayTeamId && match.HomeScore.HasValue && match.HomeScore > 0)
                    {
                        match.HomeScore--;
                        matchChanged = true;
                    }
                }
                else
                {
                   
                    if (matchEvent.TeamId == match.HomeTeamId && match.HomeScore.HasValue && match.HomeScore > 0)
                    {
                        match.HomeScore--;
                        matchChanged = true;
                    }
                    else if (matchEvent.TeamId == match.AwayTeamId && match.AwayScore.HasValue && match.AwayScore > 0)
                    {
                        match.AwayScore--;
                        matchChanged = true;
                    }
                }
            }

            
            if (matchChanged)
            {
                
                UpdateMatchResult(match);

                _matchRepository.Edit(match);
                await _matchRepository.CommitAsync();
            }
        }

        
        private bool UpdateMatchScore(Match match, MatchEvent matchEvent)
        {
            if (matchEvent.EventType != EventType.Goal) return false;

            bool isOwnGoal = matchEvent.GoalType == GoalType.OwnGoal;

            if (isOwnGoal)
            {
                
                if (matchEvent.TeamId == match.HomeTeamId)
                {
                    match.AwayScore = (match.AwayScore ?? 0) + 1;
                    return true;
                }
                else if (matchEvent.TeamId == match.AwayTeamId)
                {
                    match.HomeScore = (match.HomeScore ?? 0) + 1;
                    return true;
                }
            }
            else
            {
               
                if (matchEvent.TeamId == match.HomeTeamId)
                {
                    match.HomeScore = (match.HomeScore ?? 0) + 1;
                    return true;
                }
                else if (matchEvent.TeamId == match.AwayTeamId)
                {
                    match.AwayScore = (match.AwayScore ?? 0) + 1;
                    return true;
                }
            }

            return false;
        }

        
        private void UpdateMatchResult(Match match)
        {
            if (match.HomeScore.HasValue && match.AwayScore.HasValue)
            {
                if (match.HomeScore > match.AwayScore)
                {
                    match.Result = MatchResult.HomeWin;
                }
                else if (match.HomeScore < match.AwayScore)
                {
                    match.Result = MatchResult.AwayWin;
                }
                else
                {
                    match.Result = MatchResult.Draw;
                }
            }
            else
            {
                match.Result = MatchResult.Pending;
            }
        }
    }
}
