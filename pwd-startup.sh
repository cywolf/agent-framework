export AGENT_PORT=9000
export ETH_CONFIG="eth0"
export AGENT_NAME="StreetCred Agent"
export myhost=`ifconfig ${ETH_CONFIG} | grep inet | cut -d':' -f2 | cut -d' ' -f1 | sed 's/\./\-/g'`
export AGENT_ENDPOINT="http://ip${myhost}-${SESSION_ID}-${AGENT_PORT}.direct.${PWD_HOST_FQDN}"
echo "Agent endpoint: $AGENT_ENDPOINT"
echo "Building docker image"
docker build -f docker/web-agent.dockerfile -t web_agent .
echo "Running docker image"
docker run -it -p ${AGENT_PORT}:${AGENT_PORT} -e ASPNETCORE_URLS="${AGENT_ENDPOINT}:${AGENT_PORT}" -e ENDPOINT_HOST="${AGENT_ENDPOINT}" -e AGENT_NAME="${AGENT_NAME}" web_agent
